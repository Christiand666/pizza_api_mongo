using System.ComponentModel.DataAnnotations;

namespace Pizzageddon_DocumentDB.Models
{
    public class Topping
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public List<Allergy> Allergies { get; set; }
    }
}
