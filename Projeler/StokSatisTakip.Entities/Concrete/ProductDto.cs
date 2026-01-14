using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace StokSatisTakip.Entities.Concrete
{
    public class Product
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; } = "";
        public decimal AlisFiyati { get; set; }
        public decimal SatisFiyati { get; set; }

        
        public int Stok { get; set; }

        public string UrunTuru { get; set; } = "";

        
        public DateTime SatinAlinanTarih { get; set; }

        
        public int MinStok { get; set; } = 5;
    }
}