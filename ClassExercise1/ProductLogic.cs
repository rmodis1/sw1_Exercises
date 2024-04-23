﻿using System;
using Interface;
using Products;

namespace Logic
{
	/// <summary>
	/// Provides basic functions for the program: adding and retrieving data from lists and dictionaries
	/// </summary>

	public class ProductLogic : IProductLogic
	{

		private List<Product> _products = new List<Product>()
		{
			new DogLeash{Name = "Leather Leash", Price = 26.99M, Quantity = 5},
			new DogLeash{Name = "Bedazzled Leash", Price = 13.99M, Quantity = 0}
		};
		private Dictionary<string, DogLeash> _dogLeash = new Dictionary<string, DogLeash>() { };
		private Dictionary<string, CatFood> _catFood = new Dictionary<string, CatFood> { };

		public void AddProduct(Product product)
		{
			if (product is DogLeash)
			{
				_dogLeash.Add(product.Name, product as DogLeash);
			}
			if (product is CatFood)
			{
                _catFood.Add(product.Name, product as CatFood);
			}

			_products.Add(product);
		}

		public List<Product> GetAllProducts()
		{
			return _products;
		}

		public DogLeash GetDogLeashByName(string name)
		{
			try
			{
                return _dogLeash[name];
            }
			catch(Exception ex)
			{
				Console.WriteLine(ex);
				return null;
			}
		}

        public List<Product> GetOnlyInStockProducts()
        {
            return _products.Where(product => product.Quantity > 0)
							.ToList();
        }

        public List<Product> GetOnlyOutOfStockProducts()
        {
            return _products.Where(product => product.Quantity == 0)
							.ToList();
        }
    }
}

