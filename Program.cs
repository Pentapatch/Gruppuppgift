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

using System.Security.Cryptography;

internal class Program
{
    internal static void Main(string[] args)
    {
        int menuChoice = DisplayMenu("Välkommen till 21:an!", "Spela en runda", "Visa senaste vinnaren", "Visa spelregler", "Avsluta");

        switch (menuChoice)
        {
            case 1: // Spela en runda

                break;
            case 2: // Visa senaste vinnaren

                break;
            case 3: // Bla bla

                break;
            case 4: // Avsluta2
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("<Invalid choice>");
                break;
        }

        Console.ReadKey(true);
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

    int GetPlayerCard()
    {

        int card = rng.Next(1, 15);
        if (card == 14)
        {
            card = 11;
            return card;
        }
        if (card >= 10 || card == 13)
        {
            card = 10;
        }
        return card;
    }
    int GetCpuCard()
    {

        int card = rng.Next(1, 15);
        if (card == 14)
        {
            card = 11;
            return card;
        }
        if (card >= 10 || card == 13)
        {
            card = 10;
        }
        return card;
    }
}