using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ToyShop
{
    [DataContract]
    public class Toy : IEntity
    {
        public enum ToyGender
        {
            boy = 1,
            girl = 2,
            unisex = 3
        }

        [DataMember]
        public int Id { get; set; }
        public static int CountId { get; set; } = 0;

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public int AgeLimit { get; set; }
        [DataMember]
        public int Weight { get; set; }
        [DataMember]
        public ToyGender ToyType { get; set; }
        [DataMember]
        public string Company { get; set; }
        [DataMember]
        public string Material { get; set; }

        [DataMember]
        public int IdStorage { get; set; }
        public Storage Storage { get; set; }

        [DataMember]
        public List<int> IdDeliveryInclude { get; set; } = new List<int>();
        public List<Delivery> Deliveries { get; set; } = new List<Delivery>();

        public Toy(Toy toy)
        {
            CountId = toy.Id;
            CountId++;
            Id = toy.Id;
            Name = toy.Name;
            Price = toy.Price;
            AgeLimit = toy.AgeLimit;
            Weight = toy.Weight;
            ToyType = toy.ToyType;
            Company = toy.Company;
            Material = toy.Material;
            IdStorage = toy.IdStorage;
            IdDeliveryInclude = toy.IdDeliveryInclude;
            Deliveries = new List<Delivery>();
        }

        public Toy()
        {
            Id = CountId++;
            Deliveries = new List<Delivery>();
        }
        

        public static List<Toy> GetToysDelivery(List<Toy> toys, int id_delivery)
        {
            List<Toy> toysDelivery = new List<Toy>();

            foreach(Toy toy in toys)
            {
                if (toy.IdDeliveryInclude.Contains(id_delivery))
                    toysDelivery.Add(toy);
            }

            return toysDelivery;
        }

        public static List<Toy> GetToysStorage(List<Toy> toys, int id_storage)
        {
            List<Toy> toysStorage = new List<Toy>();

            foreach(Toy toy in toys)
            {
                if (toy.IdStorage == id_storage)
                    toysStorage.Add(toy);
            }

            return toysStorage;
        }
    }
}
