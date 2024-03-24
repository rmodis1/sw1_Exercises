using System;
using Products;

namespace Logic
{
	internal class ProductLogic
	{
        private List<Product> _products;
		private Dictionary<string, DogLeash> _dogLeash;
		private Dictionary<string, CatFood> _catFood;

		public ProductLogic()
		{
			_products = new List<Product>
            {
                new DogLeash
                {
                    Description = "A rope dog leash made from strong rope.",
                    LengthInches = 60,
                    Material = "Rope",
                    Name = "Rope Dog Leash",
                    Price = 21.00m,
                    Quantity = 0
                },
               
                new CatFood
                {
                    Quantity = 48,
                    Price = 12.99m,
                    Name = "Fancy Cat Food",
                    Description = "Food that isn't only delicious, but made from the finest of all cat food stuff",
                    KittenFood = false
                }
            };
            _dogLeash = new Dictionary<string, DogLeash>();
            _catFood = new Dictionary<string, CatFood>();
        }

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
			return _dogLeash[name];
		}
	}
}

