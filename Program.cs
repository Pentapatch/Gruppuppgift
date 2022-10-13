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

﻿namespace BlackJack
{
    internal class Program
    {
        static void PrintMainMenu()
        {
            Console.WriteLine("Press 1-4 to pick what to do:");
            Console.WriteLine("1-Play BlackJack");
            Console.WriteLine("2-Show recent winner");
            Console.WriteLine("3-Gamerules");
            Console.WriteLine("4-Exit");
        }//Prints main menu.


        static (string, int, int) Ace(int number)
        {
            return ("ace", 1, 11);
        }//Called if an ace s drawn. Returns "ace" and the min and max value of ace (1 & 11)
        static (string, int) GetCard(int number)
        {
            return number switch
            {                   
                2 => ("two", 2),
                3 => ("three", 3),
                4 => ("four", 4),
                5 => ("five", 5),
                6 => ("six", 6),
                7 => ("seven", 7),
                8 => ("eight", 8),
                9 => ("nine", 9),
                10 => ("ten", 10),
                11 => ("knight", 10),
                12 => ("queen", 10),
                13 => ("three", 10),
            };
        }
        static (string, int, int) NewRound()
        {
            //User and computerscore
            int userScore = 0;
            int cpusScore = 0;

            int blackJack = 21;
            

            //We will use this variable to generate cards. 
            Random random = new Random();
            

            if (userScore == 1)
            {

            }
        }

        static void ExitProgram()
        {
            Console.WriteLine("Thanks for playing, program is shutting down..");           
            Console.ReadKey(true);
            Environment.Exit(0);
        }//Prints a message and shuts down the program
        
        static void Main(string[] args)
        {
            //A list were we will store results. 
            List<string> resultHistory = new List<string>();

            //User and computerscore
            int userScore = 0;
            int cpusScore = 0;

            


            
            //Main menu, the whole program will stay in this while loop until the user wants to exit
            while (true)
            {
                //Print the main menu
                PrintMainMenu();
                
                //Variable to keep track of the users choice
                var keyPressed = Console.ReadKey(true);
                //Depending on wich key is pressed, different methods are called
                switch (keyPressed.Key)
                {
                        //If the user press 1, a new round will start
                    case ConsoleKey.D1:
                        break;
                        //If user press 2, the result list will be displayed
                    case ConsoleKey.D2:
                        break;
                    //If user press 3, the rules of the game will be displayed
                    case ConsoleKey.D3:
                        break;
                    //If user press 4, ExitProgram is called and the program will shut down.
                    case ConsoleKey.D4: ExitProgram();
                        break;
                }
                Console.Clear();
            }
        }
    }
}