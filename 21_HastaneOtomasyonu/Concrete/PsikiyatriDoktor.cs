using _21_HastaneOtomasyonu.Abstract;
using _21_HastaneOtomasyonu.Enum_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_HastaneOtomasyonu.Concrete
{
    public class PsikiyatriDoktor : IDoktor
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
        public double Maas
        {
            get { return _maas; }
            set { _maas=value <20000 ? 23000 :value; }
        }
        public string Unvan { get; set; }
        private Birim _birim;
        public Birim Birim
        {
            get { return _birim; }
            set { _birim=value!=Birim.Psikiyatri ? Birim.Psikiyatri : value; }
        }
        public double DonerSermayeParasi { get; set; }

        public string AmeliyatYap()
        {
            return "Ben Ameliyat Yapmam";
        }

        public string MuayeneEt()
        {
            return "Benim işim seni dinlemek";
            
        }

        public string ParaAl()
        {
            return $"Döner Sermayeden Alınan Para{DonerSermayeParasi}, Toplam Kazanç ={_maas + DonerSermayeParasi}";
        }
    }
}
