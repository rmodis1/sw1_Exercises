using System;

namespace Products
{
    public class CatFood : Product
    {
        public bool KittenFood { get; set; }

        public static CatFood ReadFromUser()
        {
            CatFood catFood = new CatFood();

            Console.WriteLine("Adding new brand of cat food!\n");

            Console.WriteLine("What is the name of the cat food?");
            while (string.IsNullOrEmpty(catFood.Name))
            {

                catFood.Name = Console.ReadLine();
                Console.WriteLine("Please enter the name of the product.");
            }

            Console.WriteLine("How much does the cat food cost?");
            bool properCost = false;
            while (properCost == false)
            {
                try
                {
                    catFood.Price = decimal.Parse(Console.ReadLine());
                    properCost = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid decimal value.");
                }
            }

            Console.WriteLine("How many bags are you adding?");
            bool properInventoryAddition = false;
            while (properInventoryAddition == false)
            {
                try
                {
                    catFood.Quantity = int.Parse(Console.ReadLine());
                    properInventoryAddition = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid integer value.");
                }
            }

            Console.WriteLine("Is this food appropriate for kittens? True/False?");
            bool properInput = false;
            while (properInput == false)
            {
                try
                {
                    catFood.KittenFood = bool.Parse(Console.ReadLine());
                    properInput = true;
                }
                catch
                {
                    Console.WriteLine("Please enter 'true' or 'false.'");
                }
            }

            Console.WriteLine("Please add a short description of the product for customers: ");
            catFood.Description = Console.ReadLine();

            return catFood;
        }
    }
}

