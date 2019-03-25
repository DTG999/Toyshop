using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;

namespace ToyShop
{
    public class JsonFileService<T> : IFileService<T>
        where T : class
    {
        public List<T> ReadFromFile(string file_name)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<T>));
            if (!File.Exists(file_name))
                File.WriteAllText(file_name, "null");
            using (FileStream fs = new FileStream(file_name, FileMode.OpenOrCreate))
            {
                List<T> jsonElements = (List<T>)jsonFormatter.ReadObject(fs);
                if (jsonElements != null)
                    return jsonElements;
                else
                    return new List<T>();
            }
        }

        public void WriteToFile(List<T> elements, string file_name)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<T>));
            using (FileStream fs = new FileStream(file_name, FileMode.Create))
            {
                if (elements.Count != 0)
                    jsonFormatter.WriteObject(fs, elements);
                else
                    jsonFormatter.WriteObject(fs, null);
            }
        }
    }
}
