Console.Write("What's your name? ");
string name = Console.ReadLine() ?? "stranger";

Console.Write("How old are you? ");
int age = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Hi {name}! In ten years, you'll be {age + 10}.");
