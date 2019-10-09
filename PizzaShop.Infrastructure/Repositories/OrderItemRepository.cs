using PizzaShop.Core.DomainServices;
using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void CreateOrderItem(OrderItem orderItem)
        {
            ctx.OrderItems.Add(orderItem);
            ctx.SaveChanges();
            
        }

        public void DeleteOrderItem(int id)
        {
            var toRemove = ReadById(id);
            ctx.OrderItems.Remove(toRemove);
            ctx.SaveChanges();
        }

        public List<OrderItem> GetAllOrderItems()
        {
            return ctx.OrderItems.ToList();
        }

        public OrderItem GetOrderItem()
        {
            throw new NotImplementedException();
        }

        public OrderItem ReadById(int id)
        {
            return ctx.OrderItems.FirstOrDefault(o => o.ItemId == id);
        }
    }
}
