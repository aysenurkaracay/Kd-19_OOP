namespace _02_Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir öğrenci nesnesi oluşturup Ad,Soyad,DogumTarihi,Sinifi,Cinsiyet bilgilerini tutunuz.Öğrenci nesnesini ad soyad bilgileri ile yaratınız.Aynı zamandda öğrenci clasında gelen doğumtarihi bilgisine göre yıl bazında yaş hesaplayan metodu yazınız.
            //Yine class içerisinde oluşan bir metotla öğrenci bilgilerini ekrana yazınız yaş bilgiside dahil.Program cs ten nesne oluşturup bilgileri ekranda gösteriniz.
            Ogrenci ogrenci = new Ogrenci("Gül", "Artman")
            {
                Cinsiyet = false,
                Sinif = "KD-19",
                DogumTarihi = new DateTime(1993, 5, 15)
            };
            ogrenci.OgrenciBilgileriniYaz();
            Console.ReadLine();

        }
    }
}