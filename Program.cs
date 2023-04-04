List<Product> products = new List<Product>()  // initialize a list with this line
{  //collection initializers {} curly braces after list initialization
    new Product()
    {
        Name = "Football",
        Price = 15.00M,
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010,
        Condition = 1.5
    },
    new Product()
    {
        Name = "Soccer",
        Price = 20.50M,  //need to have a M suffix whenever decimal integer is declared in the object
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2020,
        Condition = 5
    },
    new Product()
    {
        Name = "Boxing",
        Price = 50.99M,
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010,
        Condition = 2.3
    },
    new Product()
    {
        Name = "Hockey Stick",
        Price = 12,
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010,
        Condition = 4
    }
    // collection initializer
};

string greeting = @"Welcome to Thrown For a Loop
Your one-stop shop for used sporting equipment";

Console.WriteLine(greeting);

//? initial call of method built below:
// ViewProductDetails();

string choice = null;
while (choice != "0")
{
    Console.WriteLine(@"Choose an option:
                        0. Exit
                        1. View Product Details");
    choice = Console.ReadLine();
    if (choice == "0")
    {
        Console.WriteLine("Goodbye!");
    }
    else if (choice == "1")
    {
        ViewProductDetails();
    }
}




void ViewProductDetails()
{
    Console.WriteLine("Products:");

    decimal totalValue = 0.0M;
    foreach (Product product in products)
    {
        if (!product.Sold)
        {
            totalValue += product.Price;
        }
    }
    Console.WriteLine($"Total inventory value: ${totalValue}");

    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i]?.Name}");
    }

    //? Updated exception handling code for product (FormatException or ArgumentOutOfRangeException)
    Product chosenProduct = null;
    // while chosenProduct (which is the response from user) is null
    while (chosenProduct == null)
    {
        // run this code block
        Console.WriteLine("Please enter a product number: ");

        try
        {
            int response = int.Parse(Console.ReadLine().Trim());
            chosenProduct = products[response - 1];
        }
        catch (FormatException)
        {
            Console.WriteLine("Please type only integers!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Please choose an existing item only!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine("Do Better!");
        }
    }

    //* initial try/catch for exceptions with updates as course progressed.
    /*
    try
    {
        int response = int.Parse(Console.ReadLine().Trim());
        chosenProduct = products[response - 1];
    }
    // if an exception occurs respond with the below message and reenter chosenProduct null phase so user can enter correct format.
    // this catches the exception in ex variable!!!
    catch (Exception ex) //! Didn't have to specify the exception to catch?? 
    {
        Console.WriteLine(ex);
        Console.WriteLine("Do better!");
    }
    }
    */

    //* Old product prompt without exception handling (FormatException or ArgumentOutOfRangeException)
    Console.WriteLine("Please enter a product number: ");
    /*
        int response = int.Parse(Console.ReadLine().Trim()); //.Trim() returns a string
        while (response > products.Count || response < 1)
        // while (string.IsNullOrEmpty(response))
        {
            Console.WriteLine(@"Choose a number between 1 and 4!");
            response = int.Parse(Console.ReadLine().Trim());
        }

        Product chosenProduct = products[response - 1];
    */

    DateTime now = DateTime.Now;
    TimeSpan timeInStock = now - chosenProduct.StockDate;

    Console.WriteLine(@$"You chose: {chosenProduct.Name}, which costs {chosenProduct.Price} dollars.
It is {now.Year - chosenProduct.ManufactureYear} years old. The condition is graded {chosenProduct.Condition}.
It {(chosenProduct.Sold ? "is not available." : $"has been in stock for {timeInStock.Days} days.")}");
}


//* Calculator example from lesson...
// Console.WriteLine("Please input divisor:");
// int divisor = int.Parse(Console.ReadLine());
// Console.WriteLine("Please input dividend:");
// int dividend = int.Parse(Console.ReadLine());
// try
// {
//     Console.WriteLine($"{dividend} / {divisor} = {dividend / divisor}");
// }
// catch //(DivideByZeroException) 
// {
//     Console.WriteLine("Division of {0} by zero.", divisor);
// }





// Console.WriteLine($"You chose: {chosenProduct.Name}, which costs {chosenProduct.Price} dollars and is {(chosenProduct.Sold ? "" : "not ")}sold.");


// Console.WriteLine($"You chose: {response}");
// Console.WriteLine(@$"You chose: {response}. 
// Thank you for your input!");

// string programGreeting = "Welcome to Thrown for a Loop!";
// Console.WriteLine(programGreeting);

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Welcome to Thrown for a Loop!");
// Console.WriteLine("Please choose an option: ");