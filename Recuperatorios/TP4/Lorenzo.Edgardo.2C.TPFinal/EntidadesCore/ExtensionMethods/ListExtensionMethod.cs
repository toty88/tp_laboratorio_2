using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCore
{
    public static class ListExtensionMethod
    {
        /// <summary>
        /// Extension Method that checks whether a list cotains a class of a certain type
        /// </summary>
        /// <typeparam name="T">The type of the List to check</typeparam>
        /// <param name="list">The list that contains objects</param>
        /// <param name="type">The type to check</param>
        /// <returns>true if list contains the type - false if not"</returns>
        public static bool ContainsType<T>(this List<T> list, string type)
        {
            if (list != null && list.Count > 0)
            {
                foreach (T item in list)
                {
                    if (item.GetType().Name == type)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
