﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCore
{
    public static class SQL<T>
    {
        #region DB Select
        public static List<Product> QueryBD(string connectionString, string query)
        {
            SqlConnection conection = new SqlConnection();
            conection.ConnectionString = connectionString;
            SqlCommand command = new SqlCommand();
            command.Connection = conection;
            SqlDataReader dr;
            List<Product> tempList = new List<Product>();
            // both
            string modelName;
            int sn; bool snParse;
            float price; bool priceParse;
            // notebook
            Thinkpad notebookTemp;
            int trackpad; bool trackpadParse;
            int dock; bool dockParse;
            EScreenSize noteScreenSize; bool noteScreenSizeParse;
            // keyboard
            MechanicalKeyboard keyboardTemp;
            EKeyboardSize keebSize; bool keebSizeParse;
            int bluetooth; bool bluetoothParse;
            ESwitchColor switchColor; bool switchColorParse;

            try
            {
                if (conection.State != System.Data.ConnectionState.Open && conection.State != System.Data.ConnectionState.Connecting)
                {
                    conection.Open();
                }
                command.CommandText = query;
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    modelName = dr["Model"].ToString();
                    snParse = int.TryParse(dr["Serial_Number"].ToString(), out sn);
                    priceParse = float.TryParse(dr["Price"].ToString(), out price);
                    if (modelName.Contains("Thinkpad"))
                    {
                        noteScreenSizeParse = Enum.TryParse<EScreenSize>(dr["ScreenSize"].ToString(), out noteScreenSize);
                        trackpadParse = int.TryParse(dr["Trackpad"].ToString(), out trackpad);
                        dockParse = int.TryParse(dr["HasDockingStation"].ToString(), out dock);
                        if(noteScreenSizeParse && trackpadParse && dockParse)
                        {
                            if(dock == 1)
                            {
                                notebookTemp = new Thinkpad(modelName, price, noteScreenSize, trackpad, true);
                            }
                            else
                            {
                                notebookTemp = new Thinkpad(modelName, price, noteScreenSize, trackpad, false);
                            }
                            notebookTemp.Serial_Number = sn;
                            tempList.Add(notebookTemp);
                        }
                    }
                    else
                    {
                        keebSizeParse = Enum.TryParse<EKeyboardSize>(dr["KeyboardSize"].ToString(), out keebSize);
                        bluetoothParse = int.TryParse(dr["HasBluetooth"].ToString(), out bluetooth);
                        switchColorParse = Enum.TryParse(dr["SwtichColor"].ToString(), out switchColor);
                        if(keebSizeParse && bluetoothParse && switchColorParse)
                        {
                            if (bluetooth == 1)
                            {
                                keyboardTemp = new MechanicalKeyboard(modelName, price, keebSize, true, switchColor);
                            }
                            else
                            {
                                keyboardTemp = new MechanicalKeyboard(modelName, price, keebSize, false, switchColor);
                            }
                            keyboardTemp.Serial_Number = sn;
                            tempList.Add(keyboardTemp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error conexion BD - Mensaje: {ex.Message}");
            }
            finally
            {
                conection.Close();
            }
            return tempList;
        }
        #endregion

        #region DB Insert
        public static bool Insert(string connectionString, string query, List<string> properties, T obj)
        {
            SqlConnection conection = new SqlConnection();
            conection.ConnectionString = connectionString;
            SqlCommand command = new SqlCommand();
            command.Connection = conection;
            try
            {
                if (conection.State != System.Data.ConnectionState.Open && conection.State != System.Data.ConnectionState.Connecting)
                {
                    conection.Open();
                }
                command.CommandText = query;
                foreach(string item in properties)
                {
                    foreach(var prop in obj.GetType().GetProperties())
                    {
                        if(item == prop.Name)
                        {
                            command.Parameters.AddWithValue($"@{item}", prop.GetValue(obj, null));
                            break;
                        }
                    }
                }
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error conexion BD - Mensaje: {ex.Message}");
            }
            finally
            {
                conection.Close();
            }
        }
        #endregion

        #region Build Queries
        public static string BuildInsertQuery(List<string> properties, string table)
        {
            string query = null;
            if((properties != null) && !string.IsNullOrEmpty(table))
            {
                query = $"INSERT into {table}(";
                foreach (string item in properties)
                {
                    query += $"{item}, ";
                }
                query = query.Remove(query.Length - 2);
                query += ") values(";
                foreach (string item in properties)
                {
                    query += $"@{item}, ";
                }
                query = query.Remove(query.Length - 2);
            }
            else
            {
                throw new InvalidQueryException("Query Error! Please Check");
            }
            return query += ")";
        }
        #endregion
    }
}