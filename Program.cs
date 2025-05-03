
namespace hmw5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Journal journal = new Journal();

            journal.InputD();
            journal.DisplayD();

            Store store = new Store();

            store.InputD();
            store.DisplayD();

        }
    }

           public class Journal
        {
            public string Name { get; set; }
            public int Year { get; set; }
            public string Description { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }

            public void InputD()
            {
                Console.Write("Назва журналу: ");
                Name = Console.ReadLine();
                Console.Write("Рік заснування: ");
                Year = int.Parse(Console.ReadLine());
                Console.Write("Опис: ");
                Description = Console.ReadLine();
                Console.Write("Телефон: ");
                Phone = Console.ReadLine();
                Console.Write("Email: ");
                Email = Console.ReadLine();
            }

            public void DisplayD()
            {
                Console.WriteLine($"\nName: {Name}\nYear: {Year}\nDescription: {Description}\nPhone: {Phone}\nEmail: {Email}");
            }
        }


        public class Store
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string Description { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }

            public void InputD()
            {
                Console.Write("Назва магазину: ");
                Name = Console.ReadLine();
                Console.Write("Адреса: ");
                Address = Console.ReadLine();
                Console.Write("Опис: ");
                Description = Console.ReadLine();
                Console.Write("Телефон: ");
                Phone = Console.ReadLine();
                Console.Write("Email: ");
                Email = Console.ReadLine();
            }

            public void DisplayD()
            {
                Console.WriteLine($"\nName: {Name}\nAddress: {Address}\nDescription: {Description}\nPhone: {Phone}\nEmail: {Email}");
            }
        }
    }
}
