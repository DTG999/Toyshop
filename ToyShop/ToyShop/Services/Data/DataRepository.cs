using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    public class DataRepository : IRepository
    {
        public List<Employee> Employees { get; set; }
        public List<Toy> Toys { get; set; }
        public List<Storage> Storages { get; set; }
        public List<Delivery> Deliveries { get; set; }
        public List<User> Users { get; set; }

        private IFileSerivceComplex _fileService;

        public DataRepository(IFileSerivceComplex file_service_complex)
        {
            _fileService = file_service_complex;
        }

        public void SaveChanges()
        {
            _fileService.ServiceEmployee.WriteToFile(Employees, _fileService.FILE_EMPLOYEE);
            _fileService.ServiceToy.WriteToFile(Toys, _fileService.FILE_TOYS);
            _fileService.ServiceStorage.WriteToFile(Storages, _fileService.FILE_STORAGE);
            _fileService.ServiceDelivery.WriteToFile(Deliveries, _fileService.FILE_DELIVERY);
            _fileService.ServiceUser.WriteToFile(Users, _fileService.FILE_USER);
        }

        public void Load()
        {
            LoadData();
            LoadConnects();
            LoadConnectList();
        }

        private void LoadData()
        {
            Employees = _fileService.ServiceEmployee.ReadFromFile(_fileService.FILE_EMPLOYEE);
            Employee.CountId = Employees.Last().Id + 1;
            Toys = _fileService.ServiceToy.ReadFromFile(_fileService.FILE_TOYS);
            Toy.CountId = Toys.Last().Id + 1;
            Storages = _fileService.ServiceStorage.ReadFromFile(_fileService.FILE_STORAGE);
            Storage.CountId = Storages.Last().Id + 1;
            Deliveries = _fileService.ServiceDelivery.ReadFromFile(_fileService.FILE_DELIVERY);
            Delivery.CountId = Deliveries.Last().Id + 1;
            Users = _fileService.ServiceUser.ReadFromFile(_fileService.FILE_USER);
        }

        private void LoadConnects()
        {
            foreach (User user in Users)
            {
                user.Employee = Employees.SingleOrDefault(e => e.Id == user.IdEmployee);
            }
            foreach (Delivery delivery in Deliveries)
            {
                delivery.Deliveryman = Employees.SingleOrDefault(e => e.Id == delivery.IdDeliveryman);
            }
            foreach (Storage storage in Storages)
            {
                storage.Employee = Employees.SingleOrDefault(e => e.Id == storage.IdEmployee);
            }
            foreach (Toy toy in Toys)
            {
                toy.Storage = Storages.SingleOrDefault(s => s.Id == toy.IdStorage);
            }
        }

        private void LoadConnectList()
        {
            foreach (Delivery delivery in Deliveries)
            {
                delivery.Toys = new List<Toy>();
                foreach(Toy toy in Toys)
                {
                    toy.Deliveries = new List<Delivery>();
                    if (toy.IdDeliveryInclude.Contains(delivery.Id))
                    {
                        delivery.Toys.Add(toy);
                        toy.Deliveries.Add(delivery);
                    }
                }
            }
            foreach (Storage storage in Storages)
            {
                storage.Toys = new List<Toy>();
                foreach (Toy toy in Toys)
                {
                    if (toy.IdStorage == storage.Id)
                        storage.Toys.Add(toy);
                }
            }
        }

        public void AddObject(object obj)
        {
            if (obj is Employee)
                Employees.Add((Employee)obj);
            if (obj is Toy)
                Toys.Add((Toy)obj);
            if (obj is Storage)
                Storages.Add((Storage)obj);
            if (obj is Delivery)
                Deliveries.Add((Delivery)obj);
            if (obj is User)
                Users.Add((User)obj);

        }

        public void RemoveObject(object obj)
        {
            if (obj is Employee)
                Employees.Remove((Employee)obj);
            if (obj is Toy)
                Toys.Remove((Toy)obj);
            if (obj is Storage)
                Storages.Remove((Storage)obj);
            if (obj is Delivery)
                Deliveries.Remove((Delivery)obj);
            if (obj is User)
                Users.Remove((User)obj);

        }
    }
}
