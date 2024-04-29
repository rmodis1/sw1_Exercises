using System;
using Products;

namespace Interface
{
	public interface IProductLogic
	{
		public void AddProduct(Product product);

		public List<Product> GetAllProducts();

		public T GetProductByName<T>(string name) where T: Product;

        public List<Product> GetOnlyInStockProducts();

		public List<Product> GetOnlyOutOfStockProducts();

		public decimal GetTotalPriceOfInventory();
    }
}

