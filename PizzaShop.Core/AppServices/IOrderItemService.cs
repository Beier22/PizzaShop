using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.AppServices
{
    public interface IOrderItemService
    {
        void CreateOrderItem(OrderItem orderItem);
        List<OrderItem> ReadAllOrderItems();
        OrderItem ReadById(int id);
        void DeleteOrderItem(int id);
    }
}
