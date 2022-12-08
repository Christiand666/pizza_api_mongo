using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzageddon_DocumentDB.Models
{
    public class PizzaDetailTopping
    {
        public int Id { get; set; }
        public Topping Topping { get; set; }
        public PizzaDetail PizzaDetail { get; set; }
    }
}
