using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_InterfaceOrnek
{
    public interface INotHesapla:Ideneme
    {
        //public INotHesapla()
        //{

        //}
         double GecmeNotu { get; set; }
         double OgrenciOrtalama { get; set; }
         string Puanlama { get; set; }
         void OgrenciDurumu(double puan);
       
    }
    public interface Ideneme
    {
        void Goster();
    }
    public class Insan
    {
        private string _ad;

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }
        private string _soyad;

        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }

    }
    public class Ogrenci : Insan,INotHesapla,Ideneme
    {
        public double GecmeNotu { get; set; }
        public double OgrenciOrtalama { get; set; }
        public string Puanlama { get; set; }

        public void Goster()
        {
            throw new NotImplementedException();
        }

        public void OgrenciDurumu(double puan)
        {
            if (puan > 50)
            {
                Console.WriteLine("Geçtiniz");
            }
        }
    }
    /*
     Formda datagridwiev  yer alıcak
     IUrun isminde bir interface içerisinde id,ad,yukseklik propertyleri yer alıcak.Hacim isminde geri dönüşü int olan bir metot olucak

    Kupkutu ve dikdortgenKutu isminde 2 class olucak.Bunlar IUrunden miras alıcak
    Dikdörtgen için hacimformulu=yükseklik*kısakenar*uzunkenar
    Kupkutu için hacim=yukseklik*yükseklik*yükseklik

     
     
     
     */
}
