using MathGame;

Menu menu = new(); 

DateTime date = DateTime.UtcNow;

List<string> games = new List<string>(); 

string name = GetName();

menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Please type your name");
    string name = Console.ReadLine();
    return name;
}

