using _21_HastaneOtomasyonu.Abstract;
using _21_HastaneOtomasyonu.Enum_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_HastaneOtomasyonu.Concrete
{
    [Serializable]
    public class OrtopediDoktor : IDoktor
    {
        public int GunlukHastaSayisi { get; set; }
        public int AylikNobetSayisi { get; set; }
        public string UzmanlikAlani { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public int Yas { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        private double _maas;
        public double Maas {
            get { return _maas; }
            set
            {
                _maas = value < 20000 ? 25000 : value;
            }
         
        }
        public string Unvan { get; set; }
        private Birim _birim;
        public Birim Birim 
        {
            get { return _birim; }
            set { _birim = value != Birim.Ortopedi ? Birim.Ortopedi : value; }
        }
        public double DonerSermayeParasi { get; set; }

        public string AmeliyatYap()
        {
            return "Kıırık çıkık ameliyatı yapar gerekirse platin takar";
        }

        public string MuayeneEt()
        {
            return "Röntgen sonucunu inceleyip muayene edeceğim.";
        }

        public string ParaAl()
        {
            return $"Döner sermayeden Alınan Para {DonerSermayeParasi} ,Toplam Kazanç= {_maas + DonerSermayeParasi}";
        }
    }
}
