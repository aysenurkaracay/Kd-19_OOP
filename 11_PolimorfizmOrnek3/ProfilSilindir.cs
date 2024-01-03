using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_PolimorfizmOrnek3
{
    public class ProfilSilindir:TemelUrun
    {
        public decimal YariCap { get; set; }
        public override decimal GetTabanAlani()
        {
            return YariCap * YariCap * 22 / 7;
        }
    }
}
