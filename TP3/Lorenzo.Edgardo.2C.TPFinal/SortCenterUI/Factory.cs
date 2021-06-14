using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCore
{
    public static class Factory
    {
        static List<Product> listaProductos;
        static List<int> listOfProductsID;
        static Random random;
        static int cableTotalAmount;
        static int keycapsTotalAmount;
        static int stabilazersTotalAmount;

        static Factory()
        {
            listaProductos = new List<Product>();
            listOfProductsID = new List<int>();
            random = new Random();
            cableTotalAmount = 50;
            stabilazersTotalAmount = 100;
            keycapsTotalAmount = 300;

        }
        public static Product Create
        {
            set
            {
                try
                { 
                    value.Serial_Number = GenerateId(listOfProductsID, random);
                    if (value.Serial_Number != -1 && StockAvailable(value) && listaProductos + value)
                    {
                        if(value is Keyboard)
                        {
                            cableTotalAmount -= ((Keyboard)value).CableAmount;
                            keycapsTotalAmount -= ((Keyboard)value).KeyCapsAmount;
                            stabilazersTotalAmount -= ((Keyboard)value).Stabilazers;
                        }
                    }
                }
                catch(OutOfStockException ex)
                {
                    throw new OutOfStockException(ex.Message, ex);
                }
            }
        }
        static bool StockAvailable(Product p)
        {
            if (p is Keyboard && ((Keyboard)p).Stabilazers < stabilazersTotalAmount &&
                    ((Keyboard)p).KeyCapsAmount < keycapsTotalAmount &&
                    ((Keyboard)p).CableAmount < cableTotalAmount)
            {
                return true;
            }
            else
            {
                throw new OutOfStockException();
            }
        }
        public static string StockInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("***** STOCK DISPONIBLE *****");
            sb.AppendLine($"USB Cables left: {cableTotalAmount}");
            sb.AppendLine($"Stabilazers left: {stabilazersTotalAmount}");
            sb.AppendLine($"Keycaps left: {keycapsTotalAmount}");
            return sb.ToString();
        }
        public static string ProductsInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Product item in listaProductos)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        private static int GenerateId(List<int> list, Random r)
        {
            int newID = r.Next(0, 1001);
            bool exists = true;
            while(exists)
            {
                exists = false;
                foreach(int item in list)
                {
                    if(item == newID)
                    {
                        exists = true;
                        newID += 1;
                        break;
                    }
                }
            }
            if(!(exists))
            {
                list.Add(newID);
                return newID;
            }
            return -1;
        }
        public static void LoadMoreStock()
        {
            cableTotalAmount += random.Next(150, 200);
            stabilazersTotalAmount += random.Next(50, 100);
            keycapsTotalAmount += random.Next(1000, 2500);
        }
    }
}
