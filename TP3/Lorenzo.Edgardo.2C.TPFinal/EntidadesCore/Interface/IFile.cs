using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCore
{
    public interface IFile<T>
    {
        bool Save(string path_to_file, T obj);

    }
}
