using System;
using Products;

namespace IProduct
{
	public interface IProductLogic
	{
		public void AddProduct(Product product);

		public List<Product> GetAllProducts();

		public Product GetProductById(int id);
    }
}

