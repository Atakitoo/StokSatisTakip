using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokSatisTakip.Entities.Concrete
{
    public class Sale
    {
        public int SatisId { get; set; }
        public int MusteriId { get; set; }
        public int SatisYapanKullaniciId { get; set; }  // satış personeli
        public DateTime SatisTarihi { get; set; }
    }
}
