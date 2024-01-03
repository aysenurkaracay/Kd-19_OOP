using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_BisikletMontaji
{
    public class Bisiklet
    {
        public FrenTipi Fren { get; set; }
        public KadroTipi Kadro { get; set; }
        private int _modelYil;
        int yil = DateTime.Now.Year;
        public int ModelYil
        {
            get { return _modelYil; }
            set 
            {
                if (value < 1990 || value > yil)
                {
                    throw new Exception($"Yıl ifadesi 1990 ile {yil} arasında olabilir.");
                }
                else
                    _modelYil = value;
            }
        }
        private int _yasi;

        public int Yasi
        {
            get { return yil - ModelYil; }
           private set {; }
        }

        public override string ToString()
        {
            return $"Bisiklet Freni {Fren} - Kadrosu {Kadro} - Yaşı {Yasi}";
        }
    }
}
