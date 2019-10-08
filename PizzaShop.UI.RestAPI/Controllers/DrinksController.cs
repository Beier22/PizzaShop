using Microsoft.AspNetCore.Mvc;
using PizzaShop.Core.AppServices;
using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShop.UI.RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinksController : ControllerBase
    {
        private IDrinkService serv;
        public DrinksController(IDrinkService serv)
        {
            this.serv = serv;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Drink>> Get()
        {
            return serv.ReadAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Drink Get(int id)
        {
            return serv.ReadById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Drink drink)
        {
            serv.Create(drink);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            serv.Delete(id);
        }
    }
}
