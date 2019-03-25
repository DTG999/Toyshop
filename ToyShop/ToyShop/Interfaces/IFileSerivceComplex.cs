using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    public interface IFileSerivceComplex
    {
        string FILE_TOYS { get; }
        string FILE_EMPLOYEE { get; }
        string FILE_USER { get; }
        string FILE_STORAGE { get; }
        string FILE_DELIVERY { get; }

        IFileService<Employee> ServiceEmployee { get; }
        IFileService<Toy> ServiceToy { get; }
        IFileService<Storage> ServiceStorage { get; }
        IFileService<Delivery> ServiceDelivery { get; }
        IFileService<User> ServiceUser { get; }
    }
}
