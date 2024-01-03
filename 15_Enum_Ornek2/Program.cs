namespace _15_Enum_Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                 Id=1,
                 Name="Gül",
                 CustomerNo="34",
                  Email="gukyilmaz93@gmail.com"
            };
          CustomerRetunValue musteriKayitSonuc=  SanalDatabase.CustomerAdd(customer);

            Console.WriteLine(musteriKayitSonuc);
            Console.WriteLine((int)musteriKayitSonuc);
            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "Esra",
                Email = "esra@gmail.com",
                CustomerNo = "56"
            };
            Console.WriteLine(SanalDatabase.CustomerAdd(customer2));
            Console.ReadLine();
        }
    }
}