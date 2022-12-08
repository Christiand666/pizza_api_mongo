using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzageddon_DocumentDB.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Pizza> Pizzas { get; set; }
    }
}
