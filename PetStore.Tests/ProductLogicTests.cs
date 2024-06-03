using System;
using IProduct;
using Logic;
using Moq;
using PetStore.Data;
using PetStore.Data.OrderFiles;
using Products;

namespace PetStore.Tests
{
	[TestClass]
	public class ProductLogicTests
	{
		private readonly Mock<IProductRepository> _productRepositoryMock;
		private readonly Mock<IOrderRepository> _orderRepositoryMock;

		private readonly ProductLogic _productLogic;

		public ProductLogicTests()
		{
            _productRepositoryMock = new Mock<IProductRepository>();
            _orderRepositoryMock = new Mock<IOrderRepository>();

            _productLogic = new ProductLogic(_productRepositoryMock.Object, _orderRepositoryMock.Object);
        }

		[TestMethod]
		public void GetProductById_CallsRepo()
		{
			//Arrange
			_productRepositoryMock.Setup(z => z.GetProductById(10))
				.Returns(new Product { ProductId = 10, Name = "test product" });

			//Act
			_productLogic.GetProductById(10);

			//Assert
			_productRepositoryMock.Verify(z => z.GetProductById(10), Times.Once);
		}
	}
}

