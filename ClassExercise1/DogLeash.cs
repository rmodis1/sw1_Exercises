using System;
using System.Text.Json;
using System.Text.Json.Nodes;
using Validators;

namespace Products
{
    public class DogLeash : Product
    {
        public int LengthInches { get; set; }
        public string? Material { get; set; }

        public static DogLeash ReadFromUser()
        {
            Console.WriteLine("Adding new dog leash!\n");

            Console.WriteLine("Please add JSON information about the dog leash: ");

            string dogLeashInfo = Console.ReadLine();
            while (!dogLeashInfo.StartsWith("{") && !dogLeashInfo.EndsWith("}"))
            {
                Console.WriteLine("\nThat format does not seem quite right. Please try again.");
                dogLeashInfo = Console.ReadLine();
            }
            DogLeash dogLeash = JsonSerializer.Deserialize<DogLeash>(dogLeashInfo);

            //Add validation when possible!!!
            //try
            //{
            //    var isValid = JsonValue.Parse(dogLeashInfo);
            //}
            //catch (FormatException formatException)
            //{
            //    Console.WriteLine(formatException);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}

            DogLeashValidator dogLeashValidator = new();
            var results = dogLeashValidator.Validate(dogLeash);

            if (!results.IsValid)
            {
                foreach(var error in results.Errors)
                {
                    Console.WriteLine($"Property {error.PropertyName} failed validation. Error was {error.ErrorMessage}");
                }
            }
            else
            {
                Console.WriteLine("\nAdded dog leash!");
            }
            return dogLeash;
        }
    }
}

//Old format for populating DogLeash info
//Console.WriteLine("What is the name of the dog leash?");
//while (string.IsNullOrEmpty(dogLeash.Name))
//{

//    dogLeash.Name = Console.ReadLine();
//    Console.WriteLine("Please enter the name of the product.");
//}

//Console.WriteLine("How much does the dog leash cost?");
//bool properCost = false;
//while (properCost == false)
//{
//    try
//    {
//        dogLeash.Price = decimal.Parse(Console.ReadLine());
//        properCost = true;
//    }
//    catch
//    {
//        Console.WriteLine("Please enter a valid decimal value.");
//    }
//}

//Console.WriteLine("How many leashes are you adding?");
//bool properInventoryAddition = false;
//while (properInventoryAddition == false)
//{
//    try
//    {
//        dogLeash.Quantity = int.Parse(Console.ReadLine());
//        properInventoryAddition = true;
//    }
//    catch
//    {
//        Console.WriteLine("Please enter a valid integer value.");
//    }
//}

//Console.WriteLine("How long is the leash in inches?");
//bool properLength = false;
//while (properLength == false)
//{
//    try
//    {
//        dogLeash.LengthInches = int.Parse(Console.ReadLine());
//        properLength = true;
//    }
//    catch
//    {
//        Console.WriteLine("Please enter a valid integer value for the length of the leash.");
//    }
//}

//Console.WriteLine("What is this leash made out of?");
//while (string.IsNullOrEmpty(dogLeash.Material))
//{

//    dogLeash.Material = Console.ReadLine();
//    Console.WriteLine("Please enter the name of the product.");
//}

//Console.WriteLine("Please add a short description of the product for customers: ");
//dogLeash.Description = Console.ReadLine();