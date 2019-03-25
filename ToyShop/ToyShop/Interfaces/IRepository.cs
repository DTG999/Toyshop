using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    public interface IRepository
    {
        List<Employee> Employees { get; set; }
        List<Toy> Toys { get; set; }
        List<Storage> Storages { get; set; }
        List<Delivery> Deliveries { get; set; }
        List<User> Users { get; set; }

        void Load();
        void SaveChanges();

        void AddObject(object obj);
        void RemoveObject(object obj);
    }
}
