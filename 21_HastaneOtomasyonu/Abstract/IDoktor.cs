using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_HastaneOtomasyonu.Abstract
{
    public interface IDoktor:IInsan,ICalisan,IEkParaAl
    {

        string AmeliyatYap();
        string MuayeneEt();
        public int GunlukHastaSayisi { get; set; }
        public int AylikNobetSayisi { get; set; }
        public string UzmanlikAlani { get; set; }
    }
}
