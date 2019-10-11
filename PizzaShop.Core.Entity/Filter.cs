using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.Entity
{
    
    public enum SortByPrice
    {
        DEFAULT = 0, ASC = 1, DESC = 2
    }

    public class Filter
    {
        public int CurrentPage { get; set; }
        public Pizza Pizza { get; set; }
        public SortByPrice SortBy { get; set; }
    }
    
}
