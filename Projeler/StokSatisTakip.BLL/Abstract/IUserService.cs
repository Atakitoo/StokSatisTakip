using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StokSatisTakip.Entities.Concrete;

namespace StokSatisTakip.BLL.Abstract
{
    public interface IUserService
    {
        User Login(string email, string password);
    }
}