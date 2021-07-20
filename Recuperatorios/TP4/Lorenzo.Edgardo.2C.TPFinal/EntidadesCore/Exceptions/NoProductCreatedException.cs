using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCore
{
    public class NoProductCreatedException : Exception
    {
        public NoProductCreatedException()
        {
        }
        public NoProductCreatedException(string message)
            : base(message)
        { }
        public NoProductCreatedException(string message, Exception inner)
            : base(message, inner)
        { }
    }
}
