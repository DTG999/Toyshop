using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    public interface IFileService<T> 
        where T : class
    {
        List<T> ReadFromFile(string file_name);
        void WriteToFile(List<T> elements, string file_name);
    }
}
