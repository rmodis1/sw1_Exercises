using System;
using System.Text.Json;
using Logic;
using Products;
using Display;

internal class Program
{

    private static void Main(string[] args)
    {
        ProductLogic productLogic = new ProductLogic();
        DisplayToUser.Display();

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

            DisplayToUser.Display();
            userInput = Console.ReadLine();
        }
    }
}