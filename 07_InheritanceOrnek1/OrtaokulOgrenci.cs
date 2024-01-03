using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_InheritanceOrnek1
{
    public class OrtaokulOgrenci:Ogrenci
    {
        public string kollar { get; set; }
        public override void MesajVer()
        {
            base.MesajVer();
            Console.WriteLine("en son ben ezdim");
        }
    }
}
