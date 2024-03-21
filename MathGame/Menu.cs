using System.Diagnostics;

namespace MathGame{

    internal class Menu{

        GameEngine gameEngine = new(); 
        internal void ShowMenu(string? name, DateTime date){

            bool isGameOn = true; 

             do{
                 Console.WriteLine("--------------------------------------------------------------------------");

                Console.WriteLine($"Welcome {name}, it's {date} and this is your Math's game");

                Console.WriteLine(@$"Select one of the following operator:
        V - Previous Games
        A - Addition
        S - Substraction
        M - Multiplication
        D - Division
        R - Random Mode
        Q - Quit the program");

                Console.WriteLine("--------------------------------------------------------------------------");

                string readResult = Console.ReadLine();

                switch (readResult.ToLower().Trim())
                {
                    case "v":
                        Helpers.PrintGames(); 
                        break; 

                    case "a":
                        gameEngine.AdditionFunction();
                        break;

                    case "s":
                        gameEngine.SubstractionFunction("Welcome to the substraction game:");
                        break;

                    case "m":
                        gameEngine.MultiplicationFunction("Welcome to the multiplication game:");
                        break;

                    case "d":
                        gameEngine.DivisionFunction("Welcome to the division game:");
                        break;

                    case "r":
                        gameEngine.RandomFunction("Welcome to the random mode game:"); 
                        break; 

                    case "q":
                        Console.WriteLine("Good bye!");
                        isGameOn = false; 
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }

            } while (isGameOn); 
        }
    }
}