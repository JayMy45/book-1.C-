List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Football",
        Price = 15,
        Sold = false
    },
    new Product()
    {
        Name = "Hockey Stick",
        Price = 12,
        Sold = false
    }
    // collection initializer
};

string greeting = @"Welcome to Thrown For a Loop
Your one-stop shop for used sporting equipment";

Console.WriteLine("Products:");

for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}. {products[i].Name}");
}

Console.WriteLine("Please enter a product number: ");

int response = int.Parse(Console.ReadLine().Trim()); //.Trim() returns a string
while (response > products.Count || response < 1)
// while (string.IsNullOrEmpty(response))
{
    Console.WriteLine(@"Choose a number between 1 and 5!");
    response = int.Parse(Console.ReadLine().Trim());
}

Product chosenProduct = products[response - 1];
Console.WriteLine($"You chose: {chosenProduct.Name}, which costs {chosenProduct.Price} dollars and is {(chosenProduct.Sold ? "" : "not ")}sold.");


// Console.WriteLine($"You chose: {response}");
// Console.WriteLine(@$"You chose: {response}. 
// Thank you for your input!");

// string programGreeting = "Welcome to Thrown for a Loop!";
// Console.WriteLine(programGreeting);

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Welcome to Thrown for a Loop!");
// Console.WriteLine("Please choose an option: ");
