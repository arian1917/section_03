using System.Diagnostics;
using System.Timers;
using Academy.Console.MathGame.Models; 

namespace MathGame{
    internal class Helpers{
        internal static List<Game> games = new(); 
        internal static int[] GetDivisionNumbers(){
            Random random = new Random(); 

            int x = random.Next(1, 99);
            int y = random.Next(1, 99);

            int[] result = new int[2]; 

            
            while(x % y != 0){  
                x = random.Next(1, 99); 
                y = random.Next(1, 99); 
            }    

            result[0] = x; 
            result[1] = y;  

            return result; 
            

        }

         internal static int[] GetDivisionNumbersEasy(){
            Random random = new Random(); 

            int x = random.Next(1, 51);
            int y = random.Next(1, 51);

            int[] result = new int[2]; 

            
            while(x % y != 0){  
                x = random.Next(1, 51); 
                y = random.Next(1, 51); 
            }    

            result[0] = x; 
            result[1] = y;  

            return result; 
            

        }

         internal static int[] GetDivisionNumbersHard(){
            Random random = new Random(); 

            int x = random.Next(1, 151);
            int y = random.Next(1, 151);

            int[] result = new int[2]; 

            
            while(x % y != 0){  
                x = random.Next(1, 151); 
                y = random.Next(1, 151); 
            }    

            result[0] = x; 
            result[1] = y;  

            return result; 
            

        }

        internal static void PrintGames(){

            Console.Clear(); 
            Console.WriteLine("-------------------------------------"); 
            Console.WriteLine("Game History:"); 

            foreach(var game in games){
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} pts"); 
            }
            Console.WriteLine("-------------------------------------"); 
            Console.WriteLine("Press any key to continue to main menu"); 
            Console.ReadLine(); 
        }

        internal static void AddToHistory(GameType gameType, int gameScore)
        {
            games.Add(new Game 
            {
                Date = DateTime.Now, 
                Score = gameScore, 
                Type = gameType
            });
        }

        internal static void Scoring(int points)
        {
            if (points >= 3)
            {
                Console.WriteLine($"You scored {points} points, good job!\nPress any key to go to the main menu");
                Console.ReadLine();
            }
            else if (points <= 2)
            {
                Console.WriteLine($"You scored {points} points, you need to study more!\nPress any key to go to the main menu");
                Console.ReadLine();
            }
        }

        internal static string? ValidateResult(string result){

             while(string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _)){
                Console.WriteLine("Your input is invalid, please enter a number"); 
                result = Console.ReadLine(); 
            }
            return result; 
        }
    }
}