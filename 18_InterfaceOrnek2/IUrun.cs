using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_InterfaceOrnek2
{
    internal interface IUrun
    {
        public int id { get; set; }
        public string UrunAd { get; set; }
        public int Yukseklik { get; set; }
        int Hacim();
    }
}
