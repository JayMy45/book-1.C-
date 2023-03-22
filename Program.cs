List<string> products = new List<string>()
{
    // collection initializer
    "Football",
    "Hockey Stick",
    "Boomerang",
    "Frisbee",
    "Golf Putter"
};

string greeting = @"Welcome to Thrown For a Loop
Your one-stop shop for used sporting equipment";

Console.WriteLine("Products:");

for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}. {products[i]}");
}

Console.WriteLine("Please enter a product number: ");

int response = int.Parse(Console.ReadLine().Trim()); //.Trim() returns a string
while (response > products.Count || response < 1)
// while (string.IsNullOrEmpty(response))
{
    Console.WriteLine(@"Choose a number between 1 and 5!");
    response = int.Parse(Console.ReadLine().Trim());
}

Console.WriteLine(@$"You chose: {products[response - 1]}.
Thank you for your input!");


// Console.WriteLine($"You chose: {response}");
// Console.WriteLine(@$"You chose: {response}. 
// Thank you for your input!");

// string programGreeting = "Welcome to Thrown for a Loop!";
// Console.WriteLine(programGreeting);

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Welcome to Thrown for a Loop!");
// Console.WriteLine("Please choose an option: ");
