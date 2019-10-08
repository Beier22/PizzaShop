using System;
using System.Collections.Generic;
using System.Text;
using PizzaShop.Core.DomainServices;
using PizzaShop.Core.Entity;

namespace PizzaShop.Core.AppServices.Implementation
{
    public class FastFoodService : IFastFoodService
    {
        IFastFoodRepository repo;

        public FastFoodService(IFastFoodRepository repo)
        {
            this.repo = repo;
        }
        public void Create(FastFood fastfood)
        {
            repo.CreateFastFood(fastfood);
        }

        public void Delete(int id)
        {
            repo.DeleteFastFood(id);
        }

        public List<FastFood> ReadAll()
        {
            return repo.ReadAllFastFood();
        }

        public FastFood ReadById(int id)
        {
            return repo.ReadById(id);
        }
    }
}
