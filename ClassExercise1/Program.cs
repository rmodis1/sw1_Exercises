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

                CatFood.AddCatFood(catFood);

                productLogic.AddProduct(catFood);
                Console.WriteLine("Added cat food!");
            }
            if (userInput == "2")
            {
                DogLeash dogLeash = new DogLeash();

                DogLeash.AddDogLeash(dogLeash);

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