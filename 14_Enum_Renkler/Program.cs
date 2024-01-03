namespace _14_Enum_Renkler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enum:Numaratör ya da enum sabitleri olarak adlandırılır.

            Console.WriteLine(Renkler.Sarı);
            Console.WriteLine((int)Renkler.Sarı);
            Console.WriteLine("REnkler Enumundaki Değerleri okumak");
            foreach (int item in Enum.GetValues(typeof(Renkler)))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('#',50));

            Console.WriteLine("REnkler Enumundaki Adları okumak için");
            foreach (string item in Enum.GetNames(typeof(Renkler)))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('#',50));

            foreach (string item in Enum.GetNames<Renkler>())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}