using System;
using System.Collections.Generic;
using System.Text;
using PizzaShop.Core.DomainServices;
using PizzaShop.Core.Entity;

namespace PizzaShop.Core.AppServices.Implementation
{
    public class OrderService : IOrderService
    {
        IOrderRepository repo;
        public OrderService(IOrderRepository repo)
        {
            this.repo = repo;
        }
        public void Create(Order order)
        {
            repo.CreateOrder(order);
        }

        public void Delete(int id)
        {
            repo.DeleteOrder(id);
        }

        public List<Order> ReadAll()
        {
            return repo.ReadAllOrders();
        }

        public Order ReadById(int id)
        {
            return repo.ReadById(id);
        }
    }
}
