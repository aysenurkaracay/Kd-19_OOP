using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOPOrnek
{ /*Fırın Nesnesi oluşturunuz.İçerisinde 
            Marka,Fiyat,Güç,Model,GarantiSüresi,GarantiSüresi Olup Olmadığı ,maxDerecesi özelliklerini barındırsın.
            Nesne örneği 2 şekilde alınsın.Boş ctor da Fırın nesnesinden örnek alındığında Fırın nesnesinden örnek alındı yazsın.Diğer ctor da Marka,Model ve garantisiOlupOlmadığı bilgisini alarak nesne örneği oluşturulsun ve ekrana Fırının markası model ve garantisi olup olmadığını ekrana yazdırsın.
            Bir de içerisinde GarantiUzat isminde bir metot olsun girilen süreye göregarantiyi uzatıp garanti süresini ekrana yazsın.
            */
    public class Firin
    {
        public Firin()
        {
            Console.WriteLine("Fırın nesnesinden örnek alındı");
        }
        public Firin(string marka, string model, bool garantiVarmi)
        {
            this.Marka = marka;
            this.Model = model;
            this.GarantiVarmi = garantiVarmi;
            Console.WriteLine($"Fırın nesnesi {Marka} Marka , {Model} Modeldir.{(GarantiVarmi ? "Garanti vardır" : "Garanti yoktur")}");
        }
        public string Marka { get; set; }
        public decimal Fiyat { get; set; }
        public string Guc { get; set; }
        public string Model { get; set; }
        public int GarantiSuresi { get; set; }
        public bool GarantiVarmi { get; set; }
        public int MaxDerece { get; set; }
        public void GarantiUzat(int uzatilanSure)
        {
            GarantiSuresi += uzatilanSure;
        }
    }
}
