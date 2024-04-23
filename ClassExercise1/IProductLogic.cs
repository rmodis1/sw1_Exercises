using System;
using Products;

namespace Interface
{
	public interface IProductLogic
	{
		public void AddProduct(Product product);

		public List<Product> GetAllProducts();

		public DogLeash GetDogLeashByName(string name);

        public List<Product> GetOnlyInStockProducts();

		public List<Product> GetOnlyOutOfStockProducts();
    }
}

