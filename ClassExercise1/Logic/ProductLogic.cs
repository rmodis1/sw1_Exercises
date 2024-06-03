using System;
using System.Linq;
using IProduct;
using PetStore.Data;
using Products;
using Validators;

namespace Logic
{
	/// <summary>
	/// Provides basic functions for the program: adding and retrieving data from lists and dictionaries
	/// </summary>

	public class ProductLogic : IProductLogic
	{
		private readonly IProductRepository _productRepository; 

		public ProductLogic(IProductRepository productRepository)
		{
			_productRepository = productRepository;
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
    }
}

