using _21_HastaneOtomasyonu.Enum_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_HastaneOtomasyonu.Abstract
{
    public interface IInsan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public int   Yas { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
    }
}
