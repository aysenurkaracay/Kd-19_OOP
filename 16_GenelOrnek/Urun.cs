using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_GenelOrnek
{
    public class Urun : BaseClass
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        private double _alisFiyati;

        public double AlisFiyati
        {
            get { return _alisFiyati; }
            set
            {
                if (value <= 0) throw new Exception("Alış Fiyatı 0 dan küçük olamaz");
                else
                    _alisFiyati = value;
            }
        }
        private double _satisFiyati;

        public double SatisFiyati
        {
            get { return _satisFiyati; }
            set
            {
                if (value < _alisFiyati) throw new Exception("Alış Fiyatından Küçük olamaz");
                else
                    _satisFiyati = value;
            }
        }
        private double _kampanyaFiyati;

        public double KampanyaFiyati
        {
            get { return _kampanyaFiyati; }
            set
            {
                if (value < SatisFiyati && value > AlisFiyati && value > 0)
                    _kampanyaFiyati = value;
                else
                    throw new Exception("Kampanya Fiyatı satış fiyatından büyük veya Alış Fiyatından küçük olamaz");
            }
        }


    }
}
