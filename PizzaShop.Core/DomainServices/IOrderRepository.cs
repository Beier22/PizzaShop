using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.DomainServices
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
        List<Order> ReadAllOrders();
        Order UpdateOrder(Order updateOrder);
        void DeleteOrder(int id);
        Order ReadById(int id);
    }
}
