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
    public class PizzasController : ControllerBase
    {
        IPizzaService serv;

        public PizzasController(IPizzaService serv)
        {
            this.serv = serv;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Pizza>> Get()
        {
            return serv.GetAllPizzas(); 
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Pizza Get(int id)
        {
            return serv.ReadById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Pizza pizza)
        {
            serv.CreatePizza(pizza);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<Pizza> Put(int id, [FromBody] Pizza pizza)
        {
            if(id == pizza.Id)
            {
                serv.UpdatePizza(pizza);
            }
            else
            {
                return BadRequest("ID doesn't match");
            }
            return Ok(pizza);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            serv.DeletePizza(id);
        }
    }
}
