using PizzaShop.Core.DomainServices;
using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Infrastructure.Repositories
{
    public class OrderItemRepository : IOrderItemRepository
    {
        PizzaShopContext ctx;

        public OrderItemRepository(PizzaShopContext ctx)
        {
            this.ctx = ctx;
        }

        public List<OrderItem> GetAllOrderItems()
        {
            throw new NotImplementedException();
        }

        public OrderItem GetOrderItem()
        {
            throw new NotImplementedException();
        }
    }
}
