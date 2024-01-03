namespace _07_InheritanceOrnek1
{
    internal class Program
    {
        //Kalıtım:Bir sınıfa ait alanların,özelliklerin ve metotların kalıtım yoluyla diğer sınıflara aktarılmasına denir.
        //Kalıtımda iki kavram var 1)Temel Sınf 2)Türetilmiş sınıflar
        static void Main(string[] args)
        {
            //Kisi kisi=new Kisi();
            //  kisi.Ad = "Gül";
            //  kisi.Soyad = "Artman";
            //  kisi.BilgileriGoster();
            //Ogrenci ogrenci = new Ogrenci();
            //Ogrenci ogr = new Ogrenci("Gül");
            //ogr.BilgileriGoster();
            //ogr.MesajVer();
            OrtaokulOgrenci ortaokulOgrenci = new OrtaokulOgrenci();
            ortaokulOgrenci.kollar = "Kütüphane";
            ortaokulOgrenci.MesajVer();
            Console.ReadLine();
        }

    }
}