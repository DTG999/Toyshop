using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ToyShop
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public int IdEmployee { get; set; }
        public Employee Employee { get; set; }

        public User(User user)
        {
            Login = user.Login;
            Password = user.Password;
            IdEmployee = user.IdEmployee;
        }

        public User() { }
    }
}
