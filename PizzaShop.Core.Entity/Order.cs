using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Message { get; set; }
        public List<OrderPizza> OrderPizzas { get; set; }
        public List<OrderFastfood> OrderFastfoods { get; set; }
        public List<OrderDrink> OrderDrinks { get; set; }

    }
}
