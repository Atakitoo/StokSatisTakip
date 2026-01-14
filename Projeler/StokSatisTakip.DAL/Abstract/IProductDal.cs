using System.Collections.Generic;
using StokSatisTakip.Entities.Concrete;

namespace StokSatisTakip.DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        Product GetById(int urunId);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}