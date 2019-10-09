using PizzaShop.Core.DomainServices;
using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaShop.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        PizzaShopContext ctx;

        public OrderRepository(PizzaShopContext ctx)
        {
            this.ctx = ctx;
        }
        public void CreateOrder(Order order)
        {
            ctx.Orders.Add(order);
            ctx.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            var toRemove = ReadById(id);
            ctx.Orders.Remove(toRemove);
            ctx.SaveChanges();
        }

        public List<Order> ReadAllOrders()
        {
            return ctx.Orders.ToList();
        }

        public Order ReadById(int id)
        {
            return ctx.Orders.FirstOrDefault(o => o.Id == id);
        }

        public Order UpdateOrder(Order updateOrder)
        {
            throw new NotImplementedException();
        }
    }
}
