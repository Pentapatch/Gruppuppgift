// 21:an (Blackjack)

// -> Att generera slumptal
// -> Planera projektet
// -> Skriva pseudo kod för projektet
// -> Göra spelet
// -> Förslag på att förbättra koden

// ###############
// ## PSEUDOKOD ##
// ###############

// Skriv välkomstmeddelande

// Sätt menyVal till "0"

// while (menyval != ”4”)

// Skriv ut meny

// Läs in menyVal

// switch menyVal
// case 1: Spela en omgång av 21:an
// case 2: Visa senaste vinnaren
// case 3: Visa spelets regler
// case 4: Gör ingenting (programmet avslutas)
// default: Skriv att alternativet var ogiltigt

internal class Program
{
    private static Random rng = new(DateTime.Now.Millisecond);

    internal static void Main(string[] args)
    {
        // Stay in a loop indefinitely
        while (true)
        {
            // Clear the console
            Console.Clear();

            // Create and display a menu. Store the selected option in a variable
            int menuChoice = DisplayMenu("Välkommen till 21:an!",
                "Spela en runda", "Visa senaste vinnaren", "Visa spelregler", "Avsluta");

            // Choose what to do next
            switch (menuChoice)
            {
                case 1: // Spela en runda
                    PlayGame();
                    break;
                case 2: // Visa senaste vinnaren

                    break;
                case 3: // Visa spelets regler
                    PrintInstructions();
                    break;
                case 4: // Avsluta2
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("<Invalid choice>");
                    Console.ForegroundColor = ConsoleColor.White; // Reset
                    break;
            }

            // Wait for the user to acknowledge, before the next iteration of the loop
            Console.ReadKey(true);
        }
    }

    static void PlayGame()
    {
        Console.Clear();

        int playerCard, cpuCard, playerScore, cpuScore;

        // Get inital cards
        playerScore = GetCard(2);
        cpuScore = GetCard(2);

        // Show the initial scores
        Console.WriteLine("Initiala värderna är:");
        Console.WriteLine($"Ditt värde: {playerScore}");
        Console.WriteLine($"Datorns värde: {cpuScore}");

        while (true)
        {
            // Ask the player for another card
            test(ref playerScore);

            if (DidPlayerWin(playerScore, cpuScore))
            {
                continue;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("Game over.\nTryck på valfri knapp för att gå tillbaka till huvudmenyn...");

        Console.ReadKey(true);
    }

    static void test(ref int playerScore)
    {
        string choice = "";
        
        while (choice != "n" && playerScore <= 21)
        {
            Console.WriteLine("Vill du ha ett till kort? (j/n)");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.J:
                    int newScore = 0;
                    newScore = GetCard(1);
                    playerScore += newScore;
                    Console.WriteLine("Your new card is:" + (newScore));
                    Console.WriteLine("Your total score is" + (playerScore));
                    return;
                case ConsoleKey.N:
                    return;
            }
        }
    }

    static void PrintInstructions()
    {
        // Clear the console, then print the instructions
        Console.Clear();
        Console.WriteLine("Ditt mål är att tvinga datorn att få mer än 21 poäng.");
        Console.WriteLine("Du får poäng genom att dra kort, varje kort har 1-10 poäng.");
        Console.WriteLine("Om du får mer än 21 poäng har du förlorat.");
        Console.WriteLine("Både du och datorn får två kort i början. Därefter får du");
        Console.WriteLine("dra fler kort tills du är nöjd eller får över 21.");
        Console.WriteLine("När du är färdig drar datorn kort till den har");
        Console.WriteLine("mer poäng än dig eller över 21 poäng.");
        Console.WriteLine("\nTryck på valfri knapp för att gå tillbaka..");
    }

    private static int DisplayMenu(string message, params string[] options)
    {
        // Set up the console and print the message
        Console.Clear();
        Console.WriteLine(message + "\n");

        // Print the menu options
        for (int i = 1; i <= options.Length; i++)
        {
            Console.WriteLine($"{i}: {options[i - 1]}");
        }

        // Stay in a loop indefinitely until the user 
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            int keyPress = ConsoleKey.D9 - key.Key;

            if (keyPress >= 0 && keyPress <= 9) return 9 - keyPress;
        }
    }
    private static int GetCard(int count)
    {
        int sum = 0;
        for (int i = 0; i < count; i++)
        {
            int initialCard = rng.Next(1, 15);
            if (initialCard == 14)
            {
                initialCard = 11;
                sum += initialCard;
            }
            if (initialCard >= 10 || initialCard == 13)
            {
                initialCard = 10;
            }
            sum += initialCard;
        }

        return sum;
    }

    static bool DidPlayerWin(int playerScore, int cpuScore)
    {
        Console.WriteLine($"Din poäng: {playerScore}");
        Console.WriteLine($"Datorns poäng: {cpuScore}");

        if (playerScore > 21)
        {
            // The computer won
            return false;
        }
        else if (cpuScore > 21)
        {
            // The player won
            Console.WriteLine("Du har tyvär vunnit!");
            Console.WriteLine("ditt namn här");
            string senasteVinnaren = Console.ReadLine();
            return true;
        }
        else if (cpuScore <= playerScore)
        {
            // The player won
            return true;
        }
        else
        {
            // The computer won
            Console.WriteLine("gå och häng dig, datorn vinner");
            return false;
        }
    }

}