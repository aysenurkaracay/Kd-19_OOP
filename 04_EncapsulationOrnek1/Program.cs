namespace _04_EncapsulationOrnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //Field değer ataması yapılmasın ama değer okunsun
            //Field değer ataması ve okuma işlemleri yapılsın ama bu 2 işlem bizim belirlediğimiz  bir süreçten geçsin veri daha sonra gösterilsin.
            //Field değer ataması yapılsın ama dğerin ilk 3 hanesi okunsun.
            Musteri m=new Musteri();
           // m.id = 1;
            Console.WriteLine(m.id);
            m.Ad = "Gül";
            m.Soyad = "aRtMan";
            m.TCKimlik = "34455fd8567";
            Console.WriteLine(m.Soyad);
            Console.WriteLine(m.TCKimlik);
            Console.WriteLine(m.Email);
            Console.ReadLine();
        }
    }
}