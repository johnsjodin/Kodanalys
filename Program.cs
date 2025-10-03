namespace Kodanalys
{
    class Program
    {
        static string[] users = new string[10];
        static int userCount = 0;

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
                        if (userCount < users.Length)
                        {
                            users[userCount] = userName;
                            userCount++;
                        }
                        else
                        {
                            Console.WriteLine("Listan är full!");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Användare:");
                        for (int i = 0; i < userCount; i++)
                        {
                            Console.WriteLine(users[i]);
                        }
                        break;

                    case "3":
                        Console.Write("Ange namn att ta bort: ");
                        userName = Console.ReadLine();
                        int indexToRemove = -1;
                        for (int i = 0; i < userCount; i++)
                        {
                            if (users[i] == userName)
                            {
                                indexToRemove = i;
                                break;
                            }
                        }

                        if (indexToRemove != -1)
                        {
                            for (int i = indexToRemove; i < userCount - 1; i++)
                            {
                                users[i] = users[i + 1];
                            }
                            userCount--;
                        }
                        else
                        {
                            Console.WriteLine("Användaren hittades inte.");
                        }
                        break;

                    case "4":
                        Console.Write("Ange namn att söka: ");
                        userName = Console.ReadLine();
                        
                        for (int i = 0; i < userCount; i++)
                        {
                            if (users[i] == userName)
                            {
                                Console.WriteLine("Användaren finns i listan.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Användaren hittades inte.");
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
