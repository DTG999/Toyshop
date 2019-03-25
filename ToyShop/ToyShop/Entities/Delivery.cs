using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ToyShop
{
    [DataContract]
    public class Delivery : IEntity
    {
        [DataMember]
        public int Id { get; set; }
        public static int CountId { get; set; } = 0;

        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public DateTime TimeEnd { get; set; }
        [DataMember]
        public int IdDeliveryman { get; set; }
        public Employee Deliveryman { get; set; }
        
        public List<Toy> Toys { get; set; } = new List<Toy>();

        public Delivery(Delivery delivery)
        {
            CountId = delivery.Id;
            CountId++;
            Id = delivery.Id;
            Address = delivery.Address;
            Price = delivery.Price;
            TimeEnd = delivery.TimeEnd;
            IdDeliveryman = delivery.IdDeliveryman;
            Toys = new List<Toy>();
        }

        public Delivery()
        {
            Id = CountId++;
            Toys = new List<Toy>();
        }

        public static List<Delivery> GetDeliveries(List<Delivery> del, int id_toy)
        {
            List<Delivery> deliveries = new List<Delivery>();

            foreach(Delivery deliver in del)
            {
                if (deliver.Toys.SingleOrDefault(t => t.Id == id_toy) != null)
                    deliveries.Add(deliver);
            }

            return deliveries;
        }
    }
}
