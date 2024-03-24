using System;
using System.Text.Json;

internal class Program
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }

    class CatFood: Product
    {
        public double WeightPounds { get; set; }
        public bool KittenFood { get; set; }
    }

    class DogLeash: Product
    {
        int LengthInches { get; set; }
        string Material { get; set; }
    }

    class ProductLogic

    private static void Main(string[] args)
    {
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
                Console.WriteLine(JsonSerializer.Serialize(catFood));
            }
            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");
            userInput = Console.ReadLine();
        }
    }
}