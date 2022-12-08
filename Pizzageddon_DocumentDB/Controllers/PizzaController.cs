using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Pizzageddon_DocumentDB.Models;

namespace Pizzageddon_DocumentDB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        static private MongoClient client = new MongoClient("mongodb://localhost:27017");
        static private IMongoDatabase database = client.GetDatabase("Pizzageddon");

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var pizzaCollection = database.GetCollection<Pizza>("Pizza");

            var pizzas = await pizzaCollection.FindSync(Builders<Pizza>.Filter.Empty).ToListAsync();

            if (pizzas == null)
            {
                return NotFound();
            }

            return Ok(pizzas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var pizzaCollection = database.GetCollection<Pizza>("Pizza");

            var pizza = await pizzaCollection.Find(p => p.Id == id).SingleOrDefaultAsync();

            if (pizza == null)
            {
                return NotFound();
            }

            return Ok(pizza);
        }

        [HttpPost]
        public ActionResult Create(Pizza pizza)
        {
            var pizzaCollection = database.GetCollection<Pizza>("Pizza");

            pizzaCollection.InsertOne(pizza);

            return Ok();

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var pizzaCollection = database.GetCollection<Pizza>("Pizza");

            var pizzadelete = await pizzaCollection.FindOneAndDeleteAsync(p => p.Id == id);

            if (pizzadelete == null)
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Pizza pizza)
        {
            var pizzaCollection = database.GetCollection<Pizza>("Pizza");

            var pizzaupdate = await pizzaCollection.ReplaceOneAsync(p => p.Id == id, pizza);

            if (pizzaupdate == null)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
