using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ornek2
{//Bir öğrenci nesnesi oluşturup Ad,Soyad,DogumTarihi,Sinifi,Cinsiyet bilgilerini tutunuz.Öğrenci nesnesini ad soyad bilgileri ile yaratınız.Aynı zamandda öğrenci clasında gelen doğumtarihi bilgisine göre yıl bazında yaş hesaplayan metodu yazınız.
 //Yine class içerisinde oluşan bir metotla öğrenci bilgilerini ekrana yazınız yaş bilgiside dahil.Program cs ten nesne oluşturup bilgileri ekranda gösteriniz.
    public class Ogrenci
    {
        public Ogrenci(string Ad,string Soyad)
        {
            this.Ad = Ad;
            this.Soyad= Soyad;
            
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Sinif { get; set; }
        public bool Cinsiyet { get; set; }

        private int YasHesapla()
        {
            return DateTime.Now.Year - DogumTarihi.Year;
        }
        public void OgrenciBilgileriniYaz()
        {
            Console.WriteLine($"{Sinif} sınıfındaki {Ad} {Soyad} isimli {(Cinsiyet ? "Erkek" : "Kız")} öğrencinin yaşı {YasHesapla()}");
        }
    }
}
