using StokSatisTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StokSatisTakip.DAL.Abstract
{
    public interface ICustomerRepository
    {
        void Delete(int id);

        void Add(Customer customer);
        void Update(Customer customer);
        List<Customer> GetAll();
    }
}
