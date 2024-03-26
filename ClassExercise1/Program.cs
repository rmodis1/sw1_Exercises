using System;
using System.Text.Json;
using Logic;
using Products;

internal class Program
{

    private static void Main(string[] args)
    {
        ProductLogic productLogic = new ProductLogic();

        Console.WriteLine("Press 1 to add cat food");
        Console.WriteLine("Press 2 to add a dog leash");
        Console.WriteLine("Press 3 to view a dog leash");
        Console.WriteLine("Type 'exit' to quit");
        string userInput = Console.ReadLine();
        while (userInput.ToLower() != "exit")
        {
            if (userInput == "1")
            {
                CatFood catFood = new CatFood();

                Console.WriteLine("Adding new brand of cat food!");

                Console.WriteLine("What is the name of the cat food?");
                catFood.Name = Console.ReadLine();

                Console.WriteLine("How much does the cat food cost?");
                catFood.Price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("How many bags are you adding?");
                catFood.Quantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Is this food appropriate for kittens? True/False?");
                catFood.KittenFood = bool.Parse(Console.ReadLine());

                Console.WriteLine("Please add a short description of the product for customers: ");
                catFood.Description = Console.ReadLine();

                productLogic.AddProduct(catFood);
                Console.WriteLine("Added cat food!");
            }
            if (userInput == "2")
            {
                DogLeash dogLeash = new DogLeash();

                Console.WriteLine("Adding new dog leash!");

                Console.WriteLine("What is the name of the dog leash?");
                dogLeash.Name = Console.ReadLine();

                Console.WriteLine("How much does the dog leash cost?");
                dogLeash.Price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("How many leashes are you adding?");
                dogLeash.Quantity = int.Parse(Console.ReadLine());

                Console.WriteLine("How long is the leash in inches?");
                dogLeash.LengthInches = int.Parse(Console.ReadLine());

                Console.WriteLine("What is this leash made out of?");
                dogLeash.Material = Console.ReadLine();

                Console.WriteLine("Please add a short description of the product for customers: ");
                dogLeash.Description = Console.ReadLine();

                productLogic.AddProduct(dogLeash);
                Console.WriteLine("Added dog leash!");
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
                }
            }

            Console.WriteLine("Press 1 to add cat food");
            Console.WriteLine("Press 2 to add a dog leash");
            Console.WriteLine("Press 3 to view a dog leash");
            Console.WriteLine("Type 'exit' to quit");
            userInput = Console.ReadLine();
        }
    }
}