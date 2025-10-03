using Kodanalys.Models;

namespace Kodanalys
{
    class Program
    {
        static List<User> users = new List<User>();

        static void Main(string[] args)
        {
            bool isRunning = true;
            string userName;

            while (isRunning)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till användare");
                Console.WriteLine("2. Visa alla användare");
                Console.WriteLine("3. Ta bort användare");
                Console.WriteLine("4. Sök användare");
                Console.WriteLine("5. Avsluta");
                string menuInput = Console.ReadLine();

                switch (menuInput)
                {
                    case "1":
                        Console.Write("Ange namn: ");
                        userName = Console.ReadLine();
                        if (userName != null)
                        {
                            User user = new User { Name = userName };
                            users.Add(user);
                        }
                        break;

                    case "2":
                        Console.WriteLine("Användare:");
                        foreach (var user in users)
                        {
                            Console.WriteLine(user.Name);
                        }
                        break;

                    case "3":
                        Console.Write("Ange namn att ta bort: ");
                        userName = Console.ReadLine();
                        foreach (var user in users)
                        {
                            if (user.Name == userName)
                            {
                                users.Remove(user);
                                Console.WriteLine("Användaren togs bort.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Användaren hittades inte.");
                                break;
                            }
                        }
                        break;

                    case "4":
                        Console.Write("Ange namn att söka: ");
                        userName = Console.ReadLine();

                        foreach (var user in users)
                        {
                            if (user.Name == userName)
                            {
                                Console.WriteLine($"Användaren hittades: {user.Name}");
                                break;
                            }
                        }
                        break;

                    case "5":
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
