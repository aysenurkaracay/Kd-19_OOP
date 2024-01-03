using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_KapsullemeOrnek2
{    //Öğrenci nesnesi oluşacak .Ad,Soyad,Bolum,Sınıf ,OgrencxiNo propertyleri olucak.
     //Girilen ad değeri set edilirken ilk harfi büyük olacak şekilde değişsin.
     //Girilen soyad okunurken tüm harfleri büyük olarak ayarlansın.
     //Öğrenci no ya değer ataması yapılmasın.Ogrenci numarasına değer olrak Bölümün ilk harfinin büyük hali+Sinif+rastgele oluşan bir sayı atansın.
    public class Ogrenci
    {
        Random rnd = new Random();
        int sayi;
        public Ogrenci()
        {
            sayi = rnd.Next(1000, 9000);
        }
        private string _ad;

        public string Ad
        {
            get { return _ad; }
            set { _ad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower(); }
        }
        private string _soyad;

        public string Soyad
        {
            get { return _soyad.ToUpper(); }
            set { _soyad = value; }
        }
        public string Bolum { get; set; }
        public string Sinif { get; set; }
        private string _ogrNo;

        public string OgrNo
        {
            get 
            {
                _ogrNo = Bolum.Substring(0, 1).ToUpper() + Sinif + sayi;

                return _ogrNo;
            
            }
           private set {; }
        }


    }
}
