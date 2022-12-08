using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzageddon_DocumentDB.Models
{
    public class ExtraTopping
    {
        public int Id { get; set; }
        //public Pizza Pizza { get; set; }
        public Topping Topping { get; set; }
    }
}
