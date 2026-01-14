using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokSatisTakip.Entities.Concrete
{
    public class SaleDetail
    {
        public int SatisDetayId { get; set; }
        public int SatisId { get; set; }
        public int UrunId { get; set; }

        public int Adet { get; set; }

        // Personelin SaleForm’da girdiği fiyat (gerçek satılan)
        public decimal BirimSatisFiyati { get; set; }

        // İndirim raporu sağlam olsun diye (önerilir): satış anındaki varsayılan fiyatın kopyası
        public decimal VarsayilanBirimFiyat { get; set; }
    }
}
