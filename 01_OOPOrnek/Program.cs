namespace _01_OOPOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Fırın Nesnesi oluşturunuz.İçerisinde 
            Marka,Fiyat,Güç,Model,GarantiSüresi,GarantiSüresi Olup Olmadığı ,maxDerecesi özelliklerini barındırsın.
            Nesne örneği 2 şekilde alınsın.Boş ctor da Fırın nesnesinden örnek alındığında Fırın nesnesinden örnek alındı yazsın.Diğer ctor da Marka,Model ve garantisiOlupOlmadığı bilgisini alarak nesne örneği oluşturulsun ve ekrana Fırının markası model ve garantisi olup olmadığını ekrana yazdırsın.
            Bir de içerisinde GarantiUzat isminde bir metot olsun girilen süreye göregarantiyi uzatıp garanti süresini ekrana yazsın.
            */
            Firin firin = new Firin();
            firin.GarantiSuresi = 2;
            firin.Fiyat = 3500;
            firin.GarantiVarmi = false;
            firin.MaxDerece = 220;
            Console.WriteLine(new string('*',100));
            Firin firin2=new Firin("Siemens","1jdk3",true);
            firin2.GarantiSuresi = 2;
            firin2.GarantiUzat(2);
            Console.WriteLine($"Fırının uzatılmış garantisi {firin2.GarantiSuresi}");

            Console.ReadLine();

        }
    }
}