using System.Text.Json;
using Logic;
using Products;
using Extensions;
using Microsoft.Extensions.DependencyInjection;
using IProduct;
using PetStore.Data;
using PetStore.Data.OrderFiles;

internal class Program
{
    private static void Main(string[] args)
    {
        var serviceCollection = CreateServiceCollection();
        var productLogic = serviceCollection.GetService<IProductLogic>();

        Display();

        string? userInput = Console.ReadLine();
        while (!userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
        {
            if (userInput == "1")
            {
                Console.WriteLine("Please add a product in JSON format");
                var informationEntered = Console.ReadLine();


                var product = JsonSerializer.Deserialize<Product>(informationEntered);
                productLogic.AddProduct(product);

                Console.WriteLine("\nAdded product!");
            }
            else if (userInput == "2")
            {

                Console.WriteLine("What is the id of the product you would like to view?");
                try
                {
                    int id = int.Parse(Console.ReadLine());
                    var product = productLogic.GetProductById(id);
                    Console.WriteLine($"\n{JsonSerializer.Serialize(product)}");

                    Console.WriteLine($"\nPrice={product.Price}, Discounted Price={product.Price.DiscountThisPrice()}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"\n{e.Message}");
                    Console.WriteLine("\nSorry, please enter a valid id number.");
                }
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Add an order in JSON format");
                var informationEntered = Console.ReadLine();
                var order = JsonSerializer.Deserialize<Order>(informationEntered);
                productLogic.AddOrder(order);
            }
            else if (userInput == "4")
            {
                Console.WriteLine("What is the id of the order you would like to view?");
                try
                {
                    int id = int.Parse(Console.ReadLine());
                    var order = productLogic.GetOrder(id);
                    Console.WriteLine($"\n{JsonSerializer.Serialize(order)}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"\n{e.Message}");
                    Console.WriteLine("\nSorry, please enter a valid id number.");
                }
            }

            Display();
            userInput = Console.ReadLine();
        }
    }

    public static void Display()
    {
        Console.WriteLine("\nPress 1 to add a product");
        Console.WriteLine("Press 2 to view a product");
        Console.WriteLine("Press 3 to add an order");
        Console.WriteLine("Press 4 to get an order");
        Console.WriteLine("Type 'exit' to quit\n");
    }

    public static IServiceProvider CreateServiceCollection()
    {
        return new ServiceCollection()
            .AddTransient<IProductLogic, ProductLogic>()
            .AddTransient<IProductRepository, ProductRepository>()
            .AddTransient<IOrderRepository, OrderRepository>()
            .BuildServiceProvider();
    }
}