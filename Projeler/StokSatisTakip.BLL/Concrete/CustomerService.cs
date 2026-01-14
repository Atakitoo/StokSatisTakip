using System;
using System.Collections.Generic;
using StokSatisTakip.DAL.Concrete;
using StokSatisTakip.Entities.Concrete;

namespace StokSatisTakip.BLL.Concrete
{
    public class CustomerService
    {
        private readonly CustomerRepository _repo = new CustomerRepository();

        public List<Customer> GetAll()
        {
            return _repo.GetAll();
        }

        public void Save(Customer customer)
        {
            if (customer == null) throw new Exception("Müşteri bilgisi boş.");

            if (customer.Id == 0)
                _repo.Add(customer);
            else
                _repo.Update(customer);
        }

        public void Delete(int id)
        {
            if (id <= 0) throw new Exception("Silinecek müşteri seçilmedi.");
            _repo.Delete(id);
        }
    }
}