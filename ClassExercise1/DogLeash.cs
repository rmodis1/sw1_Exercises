using System;

namespace Products
{
    /// <summary>
    /// Creates a dog leash class that inherits from Product
    /// </summary>
  
    public class DogLeash : Product
    {
        public int LengthInches { get; set; }
        public string? Material { get; set; }

        public static DogLeash ReadFromUser()
        {
            DogLeash dogLeash = new DogLeash();

            Console.WriteLine("Adding new dog leash!\n");

            Console.WriteLine("What is the name of the dog leash?");
            while (string.IsNullOrEmpty(dogLeash.Name))
            {

                dogLeash.Name = Console.ReadLine();
                Console.WriteLine("Please enter the name of the product.");
            }

            Console.WriteLine("How much does the dog leash cost?");
            bool properCost = false;
            while (properCost == false)
            {
                try
                {
                    dogLeash.Price = decimal.Parse(Console.ReadLine());
                    properCost = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid decimal value.");
                }
            }

            Console.WriteLine("How many leashes are you adding?");
            bool properInventoryAddition = false;
            while (properInventoryAddition == false)
            {
                try
                {
                    dogLeash.Quantity = int.Parse(Console.ReadLine());
                    properInventoryAddition = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid integer value.");
                }
            }

            Console.WriteLine("How long is the leash in inches?");
            bool properLength = false;
            while (properLength == false)
            {
                try
                {
                    dogLeash.LengthInches = int.Parse(Console.ReadLine());
                    properLength = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid integer value for the length of the leash.");
                }
            }

            Console.WriteLine("What is this leash made out of?");
            while (string.IsNullOrEmpty(dogLeash.Material))
            {

                dogLeash.Material = Console.ReadLine();
                Console.WriteLine("Please enter the name of the product.");
            }

            Console.WriteLine("Please add a short description of the product for customers: ");
            dogLeash.Description = Console.ReadLine();

            return dogLeash;
        }
    }
}

