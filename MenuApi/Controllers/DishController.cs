using Microsoft.AspNetCore.Mvc;
using MenuApi.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace MenuApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DishController : ControllerBase
    {

        public DishController()
        {
        }

        // GET /dish
        [HttpGet]
        public ActionResult<IEnumerable<Dish>> GetAll()
        {
            return new List<Dish>
            {
                new Dish { Name = "Group 1 (Joseph)", Price = 120000 },
                new Dish { Name = "Caesar Salad", Price = 90 },
                new Dish { Name = "Margherita Pizza", Price = 100 }
            };
        }
    }
}

