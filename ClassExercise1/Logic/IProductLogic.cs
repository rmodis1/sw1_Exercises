using System;
using PetStore.Data;
using Products;

namespace IProduct
{
	public interface IProductLogic
	{
        public void AddProduct(Product product);

		public List<Product> GetAllProducts();
        public Product GetProductById(int id);

        public Order GetOrder(int id);
        void AddOrder(Order order);
    }
}

