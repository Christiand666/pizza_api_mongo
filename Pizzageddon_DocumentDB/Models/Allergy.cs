using System.ComponentModel.DataAnnotations;

namespace Pizzageddon_DocumentDB.Models
{
    public class Allergy
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
