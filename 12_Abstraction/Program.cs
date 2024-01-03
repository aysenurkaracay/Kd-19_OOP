namespace _12_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Abstraction:Oop nin soyutlama ilkesi,bir sınıftan nesne üretmenk mantıksız geliyorsa o sınıf soyutlanabilir.Alt sınıfların ortak özelliklerini ve işlevlerini taşıyan ama nesne olmayan üst sınıf oluşturmak istiyorsak abstract şeklinde üst sınıf oluşturabiliriz.
             */
            //Tür tür = new Tür();
            Insan insan = new Insan();
            insan.CanliTuru = "İnsan";
            insan.Aile = "Homo sapiens";
            insan.Familya = "sapiens sapiens";
            insan.TurGoster();
            insan.AileGoster();
            insan.FamilyaGoster();

            Hayvan hayvan = new Hayvan();
            hayvan.CanliTuru = "Hayvan";
            hayvan.Aile = "hh";
            hayvan.Familya = "hjk";
            hayvan.TurGoster();
            hayvan.AileGoster();
            hayvan.FamilyaGoster();
            Console.ReadLine();
        }
    }
}