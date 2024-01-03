using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_InterfaceOrnek2
{
    internal class DikdortgenKutu : IUrun
    {
        public int id { get; set; }
        public string UrunAd { get; set; }
        public int Yukseklik { get; set; }
        public int KisaKenar { get; set; }
        public int UzunKenar { get; set; }
        public int Hacim()
        {
            return UzunKenar * KisaKenar * Yukseklik;
        }
    }
}
