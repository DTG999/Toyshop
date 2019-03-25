using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    public interface IAuthService
    {
        User Authorize(string login, string password);
    }
}
