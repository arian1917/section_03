using Academy.Console.MathGame.Models; 
using System.Timers;
using System.Diagnostics;

namespace MathGame{
    internal class Levels{
        internal static void LevelsAddition(){

            Console.Clear(); 
            
            Console.WriteLine("-------------------------------------"); 
            Console.WriteLine(@$"Select one Level of Difficulty:
            1 - Easy Mode
            2 - Normal Mode 
            3 - Hard Mode
            "); 
            Console.WriteLine("-------------------------------------"); 

            
            var readResult = Console.ReadLine();

            while(string.IsNullOrEmpty(readResult) || !Int32.TryParse(readResult, out _)){
                Console.WriteLine("Your input is invalid, please enter a number"); 
                readResult = Console.ReadLine(); 
            }

            switch(readResult){
                case "1": 
                    EasyModeAddition(); 
                    break; 

                case "2":
                    NormalModeAddition(); 
                    break; 

                case "3":
                    HardModeAddition(); 
                    break; 
            }
        }

        internal static void EasyModeAddition(){

            Random random = new Random();
            int points = 0; 

            Console.WriteLine("Insert how many questions you want!"); 
            var numQuestions = Console.ReadLine(); 

            while(string.IsNullOrEmpty(numQuestions) || !Int32.TryParse(numQuestions, out _)){
                Console.WriteLine("Your input is invalid, please enter a number"); 
                numQuestions = Console.ReadLine(); 
            }

            Console.WriteLine($"You selected: {numQuestions}"); 
           
            Console.ReadLine(); 


            Stopwatch timer = Stopwatch.StartNew();
                
            Console.WriteLine("Welcome to the addition game:");


            for (int i = 0; i < int.Parse(numQuestions); i++){

                int x = random.Next(0, 21);
                int y = random.Next(0, 21);

                int sum = x + y;

                Console.Clear();
                Console.WriteLine($"{x} + {y} = ?");

                var resultSum = Console.ReadLine();

                while(string.IsNullOrEmpty(resultSum) || !Int32.TryParse(resultSum, out _)){
                    Console.WriteLine("Your input is invalid, please enter a number"); 
                    resultSum = Console.ReadLine(); 
                }

                if (int.Parse(resultSum) == sum)
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

            timer.Stop(); 
            TimeSpan elapsedTime = timer.Elapsed; 
            Console.WriteLine($"Congratulations! You completed the game in {elapsedTime.TotalSeconds:N3} seconds."); 

            Helpers.AddToHistory(GameType.Addition, points);
            Helpers.Scoring(points);      
        }      

        internal static void NormalModeAddition(){
            Random random = new Random();
            int points = 0; 

            Console.WriteLine("Insert how many questions you want!"); 
            var numQuestions = Console.ReadLine(); 

            while(string.IsNullOrEmpty(numQuestions) || !Int32.TryParse(numQuestions, out _)){
                Console.WriteLine("Your input is invalid, please enter a number"); 
                numQuestions = Console.ReadLine(); 
            }

            Console.WriteLine($"You selected: {numQuestions}"); 
           
            Console.ReadLine(); 
                
            Console.WriteLine("Welcome to the addition game:");


            for (int i = 0; i < int.Parse(numQuestions); i++){

                int x = random.Next(0, 101);
                int y = random.Next(0, 101);

                int sum = x + y;

                Console.Clear();
                Console.WriteLine($"{x} + {y} = ?");

                var resultSum = Console.ReadLine();

                while(string.IsNullOrEmpty(resultSum) || !Int32.TryParse(resultSum, out _)){
                    Console.WriteLine("Your input is invalid, please enter a number"); 
                    resultSum = Console.ReadLine(); 
                }

                if (int.Parse(resultSum) == sum)
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
        }

        internal static void HardModeAddition(){
            Random random = new Random();
            int points = 0; 

            Console.WriteLine("Insert how many questions you want!"); 
            var numQuestions = Console.ReadLine(); 

            while(string.IsNullOrEmpty(numQuestions) || !Int32.TryParse(numQuestions, out _)){
                Console.WriteLine("Your input is invalid, please enter a number"); 
                numQuestions = Console.ReadLine(); 
            }

            Console.WriteLine($"You selected: {numQuestions}"); 
           
            Console.ReadLine(); 
                
            Console.WriteLine("Welcome to the addition game:");

            for (int i = 0; i < int.Parse(numQuestions); i++){

                int x = random.Next(0, 1001);
                int y = random.Next(0, 1001);

                int sum = x + y;

                Console.Clear();
                Console.WriteLine($"{x} + {y} = ?");

                var resultSum = Console.ReadLine();

                while(string.IsNullOrEmpty(resultSum) || !Int32.TryParse(resultSum, out _)){
                    Console.WriteLine("Your input is invalid, please enter a number"); 
                    resultSum = Console.ReadLine(); 
                }

                if (int.Parse(resultSum) == sum)
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
        }
            
        

        internal static void LevelsSubstraction(){

            Console.Clear(); 
            
            Console.WriteLine("-------------------------------------"); 
            Console.WriteLine(@$"Select one Level of Difficulty:
            1 - Easy Mode
            2 - Normal Mode 
            3 - Hard Mode
            "); 
            Console.WriteLine("-------------------------------------"); 

            Random random = new Random();
            int points = 0; 

            int readResult = Convert.ToInt32(Console.ReadLine());  

            Stopwatch timer = Stopwatch.StartNew();

            if(readResult == 1){

                Console.WriteLine("Insert how many questions you want!"); 
                int numQuestions = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine($"You selected: {numQuestions}"); 
                Console.ReadLine(); 
                
                Console.WriteLine("Welcome to the addition game:");


                for (int i = 0; i < numQuestions; i++){

                    int x = random.Next(0, 11); 
                    int y = random.Next(0, 11); 

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
            }

            else if (readResult == 2){

                Console.WriteLine("Insert how many questions you want!"); 
                int numQuestions = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine($"You selected: {numQuestions}"); 
                Console.ReadLine(); 
                
                Console.WriteLine("Welcome to the addition game:");


                for (int i = 0; i < numQuestions; i++){

                    int x = random.Next(0, 51); 
                    int y = random.Next(0, 51); 

                    int sub = x - y;

                    Console.Clear(); 
                    Console.WriteLine($"{x} - {y} = ?");

                    int resultSum = Convert.ToInt32(Console.ReadLine()); 

                    if(resultSum == sub){
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
            }

            else if (readResult == 3){

                Console.WriteLine("Insert how many questions you want!"); 
                int numQuestions = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine($"You selected: {numQuestions}"); 
                Console.ReadLine(); 
                
                Console.WriteLine("Welcome to the addition game:");

                for (int i = 0; i < numQuestions; i++){

                    int x = random.Next(0, 101); 
                    int y = random.Next(0, 101); 

                    int sub = x - y;

                    Console.Clear(); 
                    Console.WriteLine($"{x} - {y} = ?");

                    int resultSum = Convert.ToInt32(Console.ReadLine()); 

                    if(resultSum == sub){
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
            }
             
            
            timer.Stop(); 
            TimeSpan elapsedTime = timer.Elapsed; 
            Console.WriteLine($"Congratulations! You completed the game in {elapsedTime.TotalSeconds:N3} seconds."); 

            Helpers.AddToHistory(GameType.Addition, points);

            Helpers.Scoring(points); 
            
        }
   
        internal static void LevelsMultiplication(){
            Console.Clear(); 
            
            Console.WriteLine("-------------------------------------"); 
            Console.WriteLine(@$"Select one Level of Difficulty:
            1 - Easy Mode
            2 - Normal Mode 
            3 - Hard Mode
            "); 
            Console.WriteLine("-------------------------------------"); 

            Random random = new Random();
            int points = 0; 

            int readResult = Convert.ToInt32(Console.ReadLine());  

            Stopwatch timer = Stopwatch.StartNew();

            if(readResult == 1){

                Console.WriteLine("Insert how many questions you want!"); 
                int numQuestions = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine($"You selected: {numQuestions}"); 
                Console.ReadLine(); 
                
                Console.WriteLine("Welcome to the addition game:");


                for (int i = 0; i < numQuestions; i++){

                    int x = random.Next(0, 11); 
                    int y = random.Next(0, 11); 

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
            }

            else if (readResult == 2){

                Console.WriteLine("Insert how many questions you want!"); 
                int numQuestions = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine($"You selected: {numQuestions}"); 
                Console.ReadLine(); 
                
                Console.WriteLine("Welcome to the addition game:");


                for (int i = 0; i < numQuestions; i++){

                    int x = random.Next(0, 51); 
                    int y = random.Next(0, 51); 

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
            }

            else if (readResult == 3){

                Console.WriteLine("Insert how many questions you want!"); 
                int numQuestions = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine($"You selected: {numQuestions}"); 
                Console.ReadLine(); 
                
                Console.WriteLine("Welcome to the addition game:");

                for (int i = 0; i < numQuestions; i++){

                    int x = random.Next(0, 101); 
                    int y = random.Next(0, 101); 

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
            }
             
            
            timer.Stop(); 
            TimeSpan elapsedTime = timer.Elapsed; 
            Console.WriteLine($"Congratulations! You completed the game in {elapsedTime.TotalSeconds:N3} seconds."); 

            Helpers.AddToHistory(GameType.Addition, points);

            Helpers.Scoring(points); 
        }
    
        internal static void LevelsDivision(){
             Console.Clear(); 
            
            Console.WriteLine("-------------------------------------"); 
            Console.WriteLine(@$"Select one Level of Difficulty:
            1 - Easy Mode
            2 - Normal Mode 
            3 - Hard Mode
            "); 
            Console.WriteLine("-------------------------------------"); 

            Random random = new Random();
            int points = 0; 

            int readResult = Convert.ToInt32(Console.ReadLine());  

            Stopwatch timer = Stopwatch.StartNew();

            if(readResult == 1){

                Console.WriteLine("Insert how many questions you want!"); 
                int numQuestions = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine($"You selected: {numQuestions}"); 
                Console.ReadLine(); 
                
                Console.WriteLine("Welcome to the addition game:");


                for (int i = 0; i < numQuestions; i++)
            {
                    int[] divisionNumbers = Helpers.GetDivisionNumbersEasy();
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
            }

            else if (readResult == 2){

                Console.WriteLine("Insert how many questions you want!"); 
                int numQuestions = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine($"You selected: {numQuestions}"); 
                Console.ReadLine(); 
                
                Console.WriteLine("Welcome to the addition game:");


                for (int i = 0; i < numQuestions; i++){
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
            }

            else if (readResult == 3){

                Console.WriteLine("Insert how many questions you want!"); 
                int numQuestions = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine($"You selected: {numQuestions}"); 
                Console.ReadLine(); 
                
                Console.WriteLine("Welcome to the addition game:");

                for (int i = 0; i < numQuestions; i++){
                    int[] divisionNumbers = Helpers.GetDivisionNumbersHard();
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
            }
             
            
            timer.Stop(); 
            TimeSpan elapsedTime = timer.Elapsed; 
            Console.WriteLine($"Congratulations! You completed the game in {elapsedTime.TotalSeconds:N3} seconds."); 

            Helpers.AddToHistory(GameType.Addition, points);

            Helpers.Scoring(points); 
        }
    }
}