using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ToyShop
{
    [DataContract]
    public class Employee : IEntity
    {
        public enum EmployeePost
        {
            Director = 1,
            Admin = 2,
            Seller = 3,
            Deliveryman = 4,
            SecurityStorage = 5
        }

        public const bool MALE = true;
        public const bool FEMALE = false;

        [DataMember]
        public int Id { get; set; }
        public static int CountId { get; set; } = 0;

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public EmployeePost Post { get; set; }
        [DataMember]
        public double Salary { get; set; }
        [DataMember]
        public bool Gender { get; set; }

        public Employee(Employee employee)
        {
            CountId = employee.Id;
            CountId++;
            Id = employee.Id;
            Name = employee.Name;
            LastName = employee.LastName;
            Post = employee.Post;
            Salary = employee.Salary;
            Gender = employee.Gender;
        }

        public Employee()
        {
            Id = CountId++;
        }


        public string FormattedName()
        {
            return Name + " " + LastName;
        }
    }
}
