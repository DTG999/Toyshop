using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyShop
{
    public class AuthService : IAuthService
    {
        public User Authorize(string login, string password)
        {
            DataRepository repository = new DataRepository(new JsonFileServiceComplex());
            repository.Load();
            User user = repository.Users.SingleOrDefault(u => u.Login == login && u.Password == password);
            if(user != null)
                return user;
            else
                return null;
        }
    }
}
