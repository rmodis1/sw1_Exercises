﻿using Products;

namespace PetStore.Data
{
    public class ProductRepository: IProductRepository
	{
        private readonly ProductContext _dbContext;

        public ProductRepository()
		{
            _dbContext = new ProductContext();
		}

        public void AddProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }

       public Product GetProductById(int productId)
        {
            return _dbContext.Products.SingleOrDefault(product => product.ProductId == productId);
        }
    }
}

