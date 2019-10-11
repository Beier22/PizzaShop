using Microsoft.EntityFrameworkCore;
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
            ctx.Orders.Attach(order).State = Microsoft.EntityFrameworkCore.EntityState.Added;
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
            var result = ctx.Orders.Include(o => o.OrderPizzas).ToList();
            return result;
        }

        public Order ReadById(int id)
        {
            return ctx.Orders.Include(o => o.OrderPizzas).FirstOrDefault(o => o.Id == id);
        }

        public Order UpdateOrder(Order updateOrder)
        {
            throw new NotImplementedException();
        }
    }
}
