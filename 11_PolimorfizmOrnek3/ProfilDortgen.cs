using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_PolimorfizmOrnek3
{
    public class ProfilDortgen:TemelUrun
    {
        public decimal UzunKenar { get; set; }
        public decimal KisaKenar { get; set; }
        public override decimal GetTabanAlani()
        {
            return UzunKenar * KisaKenar;
        }
        public override string ToString()
        {
            return Id + " " + UrunAd;
        }

    }
}
