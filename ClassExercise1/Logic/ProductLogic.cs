using System;
using System.Linq;
using IProduct;
using PetStore.Data;
using Products;
using Validators;
using PetStore.Data.OrderFiles;

namespace Logic
{
	/// <summary>
	/// Provides basic functions for the program: adding and retrieving data from lists and dictionaries
	/// </summary>

	public class ProductLogic : IProductLogic
	{
		private readonly IProductRepository _productRepository;
		private readonly IOrderRepository _orderRepository;

		public ProductLogic(IProductRepository productRepository, IOrderRepository orderRepository)
		{
			_productRepository = productRepository;
			_orderRepository = orderRepository;
		}

        public void AddProduct(Product product)
		{
			var validator = new ProductValidator();
			if (validator.Validate(product).IsValid)
			{
				_productRepository.AddProduct(product);
			}
		}

		public List<Product> GetAllProducts()
		{
			return _productRepository.GetAllProducts();
		}

        public Product GetProductById(int id)
		{
			return _productRepository.GetProductById(id);
		}

        public void AddOrder(Order order)
        {
			_orderRepository.AddOrder(order);
        }

        public Order GetOrder(int id)
        {
            return _orderRepository.GetOrder(id);
        }
    }
}

