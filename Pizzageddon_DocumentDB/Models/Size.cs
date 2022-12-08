using System.ComponentModel.DataAnnotations;

namespace Pizzageddon_DocumentDB.Models
{
    public class Size
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
