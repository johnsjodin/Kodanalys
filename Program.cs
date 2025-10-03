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

                if (menuInput == "1")
                {
                    Console.Write("Ange namn: ");
                    userName = Console.ReadLine();
                    if (userCount < 10)
                    {
                        users[userCount] = userName;
                        userCount++;
                    }
                    else
                    {
                        Console.WriteLine("Listan är full!");
                    }
                }
                else if (menuInput == "2")
                {
                    Console.WriteLine("Användare:");
                    for (int i = 0; i < userCount; i++)
                    {
                        Console.WriteLine(users[i]);
                    }
                }
                else if (menuInput == "3")
                {
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
                }
                else if (menuInput == "4")
                {
                    Console.Write("Ange namn att söka: ");
                    userName = Console.ReadLine();
                    bool userFound = false;
                    for (int i = 0; i < userCount; i++)
                    {
                        if (users[i] == userName)
                        {
                            userFound = true;
                            break;
                        }
                    }
                    if (userFound)
                    {
                        Console.WriteLine("Användaren finns i listan.");
                    }
                    else
                    {
                        Console.WriteLine("Användaren hittades inte.");
                    }
                }
                else if (menuInput == "5")
                {
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Ogiltigt val.");
                }
                Console.WriteLine();
            }
        }
    }
}
