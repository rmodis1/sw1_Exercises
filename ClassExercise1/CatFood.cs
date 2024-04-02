using System;
using Logic;
using Logic; 

namespace Products
{
    /// <summary>
    /// Creates a class for cat food products that inherits from Products
    /// </summary>

    public class CatFood : Product
    {
        public bool KittenFood { get; set; }

        public static void AddCatFood(CatFood catFood)
        {
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
        }
    }
}

