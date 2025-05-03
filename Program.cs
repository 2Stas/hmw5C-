using static hmw5.Website;

namespace hmw5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Website site = new Website();

            site.InputD();
            site.DisplayD();

            Journal journal = new Journal();

            journal.InputD();
            journal.DisplayD();

            Store store = new Store();

            store.InputD();
            store.DisplayD();

        }
    }

    public class Website
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string IP { get; set; }

        public void InputD()
        {
            Console.Write("Назва сайту: ");
            Name = Console.ReadLine();
            Console.Write("URL: ");
            Url = Console.ReadLine();
            Console.Write("Опис: ");
            Description = Console.ReadLine();
            Console.Write("IP-адреса: ");
            IP = Console.ReadLine();
        }

        public void DisplayD()
        {
            Console.WriteLine("\n--- Інформація про сайт ---");
            Console.WriteLine($"Назва: {Name}");
            Console.WriteLine($"URL: {Url}");
            Console.WriteLine($"Опис: {Description}");
            Console.WriteLine($"IP-адреса: {IP}");
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