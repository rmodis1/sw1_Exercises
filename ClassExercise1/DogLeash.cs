using System;

namespace Products
{
    /// <summary>
    /// Creates a dog leash class that inherits from Product
    /// </summary>
  
    public class DogLeash : Product
    {
        public int LengthInches { get; set; }
        public string Material { get; set; }

        public static void AddDogLeash(DogLeash dogLeash)
        {
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
        }
    }
}

