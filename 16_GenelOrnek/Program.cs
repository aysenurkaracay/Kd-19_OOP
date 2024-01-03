namespace _16_GenelOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Bilgisayar bilgisayar = new Bilgisayar()
                {
                    Marka="Lenova",
                    Model="z50",
                     Islemci="i5",
                     AlisFiyati=20000,
                     SatisFiyati=35000,
                     KampanyaFiyati=22000,
                     Barkod="12345"
                    
                };
                SanalDatabase.YeniUrunEkle(bilgisayar);
                Bilgisayar bilgisayar2 = new Bilgisayar()
                {
                    Marka = "Lenova",
                    Model = "z50",
                    Islemci = "i5",
                    AlisFiyati = 20000,
                    SatisFiyati = 25000,
                    KampanyaFiyati = 21000,
                    Barkod = "123456"

                };
                Console.WriteLine( SanalDatabase.YeniUrunEkle(bilgisayar2));

                Televizyon televizyon = new Televizyon()
                {
                    SmartTV = true,
                    Barkod = "1234567",
                    Marka = "SAmsung",
                    AlisFiyati = 30000,
                    SatisFiyati = 32000,
                    KampanyaFiyati = 31000
                };
                SanalDatabase.YeniUrunEkle(televizyon);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
          
            Console.ReadLine();
        }
    }
}