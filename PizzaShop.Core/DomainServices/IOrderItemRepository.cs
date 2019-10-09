using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.DomainServices
{
    public interface IOrderItemRepository
    {
        List<OrderItem> GetAllOrderItems();
        OrderItem GetOrderItem();
    }
}
