using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCore
{
    public class DataErrorException : Exception
    {
        public DataErrorException()
        {
        }
        public DataErrorException(string message)
            : base(message)
        { }
        public DataErrorException(string message, Exception inner)
            : base(message, inner)
        { }
    }
}

