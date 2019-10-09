using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.AppServices
{
    public interface IOrderService
    {
        void Create(Order order);
        List<Order> ReadAll();
        Order ReadById(int id);
        void Delete(int id);
    }
}
