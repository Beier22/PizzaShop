using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.AppServices
{
    public interface IOrderService
    {
        void CreateOrder(Order order);
        List<Order> ReadAllOrders();
        Order ReadById(int id);
        void DeleteOrder(int id);
    }
}
