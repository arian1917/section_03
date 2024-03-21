using System.Diagnostics;
using Academy.Console.MathGame.Models; 

namespace MathGame{
    internal class GameEngine{
        internal void AdditionFunction(){ 
            Levels.LevelsAddition(); 
        }

        internal void SubstractionFunction(string message){
            Levels.LevelsSubstraction(); 
        }

        internal void MultiplicationFunction(string message){
            Levels.LevelsMultiplication();
        }

        internal void DivisionFunction(string message){
            Levels.LevelsDivision();

        }

        internal void RandomFunction(string message){
            Console.Clear(); 

            Console.WriteLine("Insert how many questions you want!"); 
            int numQuestions = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine($"You selected: {numQuestions}"); 
            Console.ReadLine(); 

            Console.WriteLine(message); 

            int points = 0; 

            Random random = new Random(); 
            
            Stopwatch timer = Stopwatch.StartNew(); 


            for(int i = 0; i < 5; i++){

                int pickFunction = random.Next(0, 4); 

                if(pickFunction == 0){
                    int x = random.Next(0, 100);
                    int y = random.Next(0, 100);

                    int sum = x + y;

                    Console.Clear();
                    Console.WriteLine($"{x} + {y} = ?");

                    int resultSum = Convert.ToInt32(Console.ReadLine());

                    if (resultSum == sum)
                    {
                        Console.WriteLine($"You're correct: {x} + {y} = {sum}.\nPress any key for continue");
                        points += 2;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect:{x} + {y} = {sum}.\nPress any key for continue");
                        points--;
                        Console.ReadLine();
                    } 
                }

                else if(pickFunction == 1){
                    int x = random.Next(0, 100); 
                    int y = random.Next(0, 100); 

                    int sub = x - y;

                    Console.Clear(); 
                    Console.WriteLine($"{x} - {y} = ?");

                    int resultSub = Convert.ToInt32(Console.ReadLine()); 

                    if(resultSub == sub){
                        Console.WriteLine($"You're correct: {x} - {y} = {sub}.\nPress any key for continue");
                        points += 2;  
                        Console.ReadLine(); 
                    }
                    else{
                        Console.WriteLine($"Incorrect:{x} - {y} = {sub}.\nPress any key for continue");
                        points--; 
                        Console.ReadLine(); 
                    }
                    
                }
                else if(pickFunction == 2){
                    int x = random.Next(0, 21); 
                    int y = random.Next(0, 21); 

                    int mult = x * y;

                    Console.Clear(); 
                    Console.WriteLine($"{x} * {y} = ?");

                    int resultMult = Convert.ToInt32(Console.ReadLine()); 

                    if(resultMult == mult){
                        Console.WriteLine($"You're correct: {x} * {y} = {mult}.\nPress any key for continue");
                        points += 2;  
                        Console.ReadLine(); 
                    }
                    else{
                        Console.WriteLine($"Incorrect:{x} * {y} = {mult}.\nPress any key for continue");
                        points--; 
                        Console.ReadLine(); 
                    }
                }
                else if(pickFunction == 3){
                    int[] divisionNumbers = Helpers.GetDivisionNumbers();
                    int x = divisionNumbers[0];
                    int y = divisionNumbers[1];

                    int div = x / y;

                    Console.Clear();
                    Console.WriteLine($"{x} / {y} = ?");
                    int resultDiv = Convert.ToInt32(Console.ReadLine());

                    if (resultDiv == div)
                    {
                        Console.WriteLine($"You're correct: {x} / {y} = {div}.\nPress any key for continue");
                        points += 2;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect:{x} / {y} = {div}.\nPress any key for continue");
                        points--;
                        Console.ReadLine();
                    }
                }
                else{
                    Console.WriteLine("Error, out of range"); 
                }
            }
            
            Helpers.AddToHistory(GameType.Random, points);
            Helpers.Scoring(points); 
        }
    }
}