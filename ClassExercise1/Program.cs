using System;
using System.Text.Json;
using Logic;
using Products;
using Extensions;

internal class Program
{

    private static void Main(string[] args)
    {
        ProductLogic productLogic = new ProductLogic();
        Display();

        string? userInput = Console.ReadLine();
        while (!userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
        {
            if (userInput == "1")
            {
                CatFood catFood = CatFood.ReadFromUser();

                productLogic.AddProduct(catFood);
                Console.WriteLine("\nAdded cat food!");
            }
            if (userInput == "2")
            {
                DogLeash dogLeash = DogLeash.ReadFromUser();

                productLogic.AddProduct(dogLeash);
                Console.WriteLine("\nAdded dog leash!");
            }
            if (userInput == "3")
            {
                Console.WriteLine("What kind of dog leash would you like to see?");
                DogLeash dogLeash = productLogic.GetDogLeashByName(Console.ReadLine());

                if (dogLeash is null)
                {
                    Console.WriteLine("Sorry, this product could not be found.");
                }
                else
                {
                    Console.WriteLine(JsonSerializer.Serialize(dogLeash));
                    Console.WriteLine($"Price={dogLeash.Price}, Discounted Price={dogLeash.Price.DiscountThisPrice()}");
                }
            }
            if (userInput == "4")
            {
                List<Product> inStockProducts = productLogic.GetOnlyInStockProducts();
                foreach (var product in inStockProducts)
                {
                    Console.WriteLine(JsonSerializer.Serialize(product));
                }
            }
            if (userInput == "5")
            {
                List<Product> inStockProducts = productLogic.GetOnlyOutOfStockProducts();
                foreach (var product in inStockProducts)
                {
                    Console.WriteLine(JsonSerializer.Serialize(product));
                }
            }
            if ( userInput == "6")
            {
                Console.WriteLine(productLogic.GetTotalPriceOfInventory());
            }
            else
            {
                Console.WriteLine("Please enter one of the options in the menu.");
            }

            Display();
            userInput = Console.ReadLine();
        }
    }

    public static void Display()
    {
        Console.WriteLine("\nPress 1 to add cat food");
        Console.WriteLine("Press 2 to add a dog leash");
        Console.WriteLine("Press 3 to view a dog leash");
        Console.WriteLine("Press 4 to view in stock items");
        Console.WriteLine("Press 5 to view out of stock items");
        Console.WriteLine("Press 6 to get the total price of the entire inventory");
        Console.WriteLine("Type 'exit' to quit\n");
    }
}