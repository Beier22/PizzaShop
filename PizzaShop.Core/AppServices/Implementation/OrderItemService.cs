using System;
using System.Collections.Generic;
using System.Text;
using PizzaShop.Core.DomainServices;
using PizzaShop.Core.Entity;

namespace PizzaShop.Core.AppServices.Implementation
{
    public class OrderItemService : IOrderItemService
    {
        IOrderItemRepository repo;
        public OrderItemService(IOrderItemRepository repo)
        {
            this.repo = repo;
        }
        public void CreateOrderItem(OrderItem orderItem)
        {
            repo.CreateOrderItem(orderItem);

        }

        public void DeleteOrderItem(int id)
        {
            repo.DeleteOrderItem(id);
        }

        public List<OrderItem> ReadAllOrderItems()
        {
            return repo.GetAllOrderItems();
        }

        public OrderItem ReadById(int id)
        {
            return repo.ReadById(id);
        }
    }
}
