using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzageddon_DocumentDB.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public Size Size { get; set; }
        public Crusttype Crusttype { get; set; }
        public PizzaDetail PizzaDetail { get; set; }
    }
}
