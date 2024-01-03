using _21_HastaneOtomasyonu.Enum_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_HastaneOtomasyonu.Abstract
{
    public interface ICalisan
    {
        public double Maas { get; set; }
        public string Unvan { get; set; }
        public Birim Birim { get; set; }
    }
}
