using System;
using Product;

namespace Logic
{
	internal class ProductLogic
	{
        private List<Product> _products;

        public ProductLogic()
		{
			_products = new List<Product>
			{

			}
		}

		public void AddProduct(ProductLogic product)
		{
			_products.Add(product);
		}

		public List<Product> GetAllProducts()
		{
			return _products;
		}
	}
}

