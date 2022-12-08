using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzageddon_DocumentDB.Models
{
    public class PizzaDetail
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public DateTime ProcessTime { get; set; }
        public List<Topping> Toppings { get; set; }
        //public List<ExtraTopping> ExtraToppings { get; set; }
    }
}
