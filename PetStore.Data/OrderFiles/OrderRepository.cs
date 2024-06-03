using System;
using Microsoft.EntityFrameworkCore;

namespace PetStore.Data.OrderFiles
{
	public class OrderRepository: IOrderRepository
	{
        private readonly ProductContext _dbContext;

		public OrderRepository()
		{
            _dbContext = new ProductContext();
		}

        public void AddOrder(Order order)
        {
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
        }

        public Order GetOrder(int id)
        {
            return _dbContext.Orders.Include(order => order.Products).SingleOrDefault(order => order.OrderId == id);
        }
    }
}

