using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ToyShop
{
    [DataContract]
    public class Storage : IEntity
    {
        [DataMember]
        public int Id { get; set; }
        public static int CountId { get; set; } = 0;

        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public int CountToys { get; set; }
        [DataMember]
        public int IdEmployee { get; set; }
        public Employee Employee { get; set; }

        public List<Toy> Toys { get; set; } = new List<Toy>();

        public Storage(Storage storage)
        {
            CountId = storage.Id;
            CountId++;
            Id = storage.Id;
            Address = storage.Address;
            CountToys = storage.CountToys;
            IdEmployee = storage.IdEmployee;
            Toys = new List<Toy>();
        }

        public Storage()
        {
            Id = CountId++;
            Toys = new List<Toy>();
        }
    }
}
