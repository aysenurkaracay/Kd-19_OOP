namespace _09_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Çok Biçimlilik
            Metotlar dönüş tipi,giriş parametresive tipleri bakımından aynı olsa da bazı durumlarda biribirinden farklı şekilde çalışmasını isteyebilir.Böyle durumlarda temel sınıfta bulunan  bir metodun türetilen sınıf tarafından yeniden şekillendirilip çalıştırılmasına çok biçimlilik denir.
             
             
             
             */


            Urun u=new Urun();
            u.EkranaYaz("Bilgisayar");
            Televizyon t=new Televizyon();
            t.EkranaYaz("samsung");
            Console.ReadLine();
        }
    }
}