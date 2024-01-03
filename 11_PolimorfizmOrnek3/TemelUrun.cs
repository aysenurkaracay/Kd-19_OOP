using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_PolimorfizmOrnek3
{
    public class TemelUrun
    {
        public int Id { get; set; }
        private string _urunAd;

        public string UrunAd
        {
            get { return _urunAd; }
            set
            {
                _urunAd = value.Substring(0, 1).ToUpper().PadRight(value.Length, '*');

             }
        }

        public decimal Yukseklik { get; set; }
        public decimal GetHacim()
        {
            return GetTabanAlani() * Yukseklik;
        }
        public virtual decimal GetTabanAlani()
        {
            return Yukseklik * Yukseklik;
        }
        public decimal Fire()
        {
            return GetHacim() * 20 / 100;
        }
    }
}
