using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokSatisTakip.Entities.Concrete;

namespace StokSatisTakip.DAL.Abstract
{
    public interface IUserRepository
    {
        User GetByEmailAndPassword(string email, string password);
    }
}