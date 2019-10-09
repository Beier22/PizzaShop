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
        public void CreateOrder(Order order)
        {
            repo.CreateOrder(order);
        }

        public void DeleteOrder(int id)
        {
            repo.DeleteOrder(id);
        }

        public List<Order> ReadAllOrders()
        {
            return repo.ReadAllOrders();
        }

        public Order ReadById(int id)
        {
            return repo.ReadById(id);
        }
    }
}
