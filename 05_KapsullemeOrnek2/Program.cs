namespace _05_KapsullemeOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Öğrenci nesnesi oluşacak .Ad,Soyad,Bolum,Sınıf ,OgrencxiNo propertyleri olucak.
            //Girilen ad değeri set edilirken ilk harfi büyük olacak şekilde değişsin.
            //Girilen soyad okunurken tüm harfleri büyük olarak ayarlansın.
            //Öğrenci no ya değer ataması yapılmasın.Ogrenci numarasına değer olrak Bölümün ilk harfinin büyük hali+Sinif+rastgele oluşan bir sayı atansın.
            Ogrenci ogrenci = new Ogrenci()
            {
                Ad = "Ayşenur",
                Soyad = "Karaçay",
                Bolum = "web",
                Sinif = "19",
               
            };
            Console.WriteLine(ogrenci.Ad);
            Console.WriteLine(ogrenci.Soyad);
            Console.WriteLine(ogrenci.OgrNo);
            Ogrenci ogrenci2 = new Ogrenci()
            {
                Ad = "Betül",
                Soyad = "Karaçay",
                Bolum = "pomem",
                Sinif = "12",

            };
            Console.WriteLine(ogrenci2.Ad);
            Console.WriteLine(ogrenci2.Soyad);
            Console.WriteLine(ogrenci2.OgrNo);
            Console.ReadLine();
        }
    }
}