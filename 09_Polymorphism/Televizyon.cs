using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Polymorphism
{
    public class Televizyon:Urun
    {
        public override void EkranaYaz(string data)
        {
            Console.WriteLine($"Datamız {data}");
        }
    }
}
