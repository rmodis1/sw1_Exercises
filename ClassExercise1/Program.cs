using System;
using System.Text.Json;
using Logic;
using Products;

internal class Program
{

    private static void Main(string[] args)
    {
        ProductLogic productLogic = new ProductLogic();

        Console.WriteLine("Press 1 to add a product");
        Console.WriteLine("Type 'exit' to quit");
        string userInput = Console.ReadLine();
        while (userInput.ToLower() != "exit")
        {
            if (userInput == "1")
            {
                CatFood catFood = new CatFood();

                Console.WriteLine("Adding new brand of cat food!");

                Console.WriteLine("How heavy is the cat food?");
                catFood.WeightPounds = int.Parse(Console.ReadLine());

                Console.WriteLine("Is this food appropriate for kittens? True/False?");
                catFood.KittenFood = bool.Parse(Console.ReadLine());

                productLogic.AddProduct(catFood);
                Console.WriteLine("Added cat food!");
            }
            if (userInput == "2")
            {
                DogLeash dogLeash = productLogic.GetDogLeashByName(Console.ReadLine());

                Console.WriteLine("What kind of dog leash would you like to see?");
                Console.WriteLine(JsonSerializer.Serialize(dogLeash));
                
            }

            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");
            userInput = Console.ReadLine();
        }
    }
}