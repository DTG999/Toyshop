using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    public class JsonFileServiceComplex : IFileSerivceComplex
    {
        public string FILE_TOYS { get { return "toys.json"; } }
        public string FILE_EMPLOYEE { get { return "employees.json"; } }
        public string FILE_USER { get { return "users.json"; } }
        public string FILE_STORAGE { get { return "storages.json"; } }
        public string FILE_DELIVERY { get { return "deliveries.json"; } }

        public IFileService<Employee> ServiceEmployee { get { return new JsonFileService<Employee>(); } }
        public IFileService<Toy> ServiceToy { get { return new JsonFileService<Toy>(); } }
        public IFileService<Storage> ServiceStorage { get { return new JsonFileService<Storage>(); } }
        public IFileService<Delivery> ServiceDelivery { get { return new JsonFileService<Delivery>(); } }
        public IFileService<User> ServiceUser { get { return new JsonFileService<User>(); } }
    }
}
