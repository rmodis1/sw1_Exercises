using System;
using Products;

namespace Logic
{
	class ProductLogic
	{
        private List<Product> _products = new List<Product>() { };
		private Dictionary<string, DogLeash> _dogLeash = new Dictionary<string, DogLeash>(){};
		private Dictionary<string, CatFood> _catFood = new Dictionary<string, CatFood>{ };

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
				return null;
			}
		}
	}
}

