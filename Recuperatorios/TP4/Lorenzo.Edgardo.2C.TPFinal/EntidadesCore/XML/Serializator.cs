﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace EntidadesCore
{
    public class Serializator<T> : IFile<T>
    {
        /// <summary>
        /// Metodo que serializa un objeto en un archivo de tipo XML
        /// </summary>
        /// <param name="path_to_file">la ruta del archivo</param>
        /// <param name="obj">EL objeto a serializar</param>
        /// <returns>true si se serializo ok, false caso contrario</returns>
        public bool SaveXML(string path_to_file, T obj)
        {
            try
            {
                if (!(path_to_file is null))
                {
                    using (XmlTextWriter writer = new XmlTextWriter(path_to_file, Encoding.UTF8))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));
                        serializer.Serialize(writer, obj);
                        return true;
                    }
                }
                throw new NullPathException("ERROR: Ruta Incorrecta");
            }
            catch (NullPathException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR: Ocurrio un problema al tratar de Serializar Datos\n" + ex.InnerException);
            }
        }

        /// <summary>
        /// Metodo que DEserializa un objeto de tipo T (permitiendo ser lista de objetos u objeto unico)
        /// </summary>
        /// <param name="path_to_file">La ruta donde se encuentra el XML</param>
        /// <param name="obj">El objeto donde se guardara el objeto deserializado</param>
        /// <returns>EL objeto Deserializado</returns>
        public T OpenXML(string path_to_file, T obj)
        {
            try
            {
                if (!(path_to_file is null))
                {
                    using (XmlTextReader reader = new XmlTextReader(path_to_file))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));
                        obj = (T)serializer.Deserialize(reader);
                    }
                    return obj;
                }
                throw new NullPathException("ERROR: Ruta Incorrecta");
            }
            catch (NullPathException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR: Ocurrio un problema al tratar de Deserializar Datos\n" + ex.InnerException);
            }
        }
    }
}

