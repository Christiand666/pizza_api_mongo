using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzageddon_DocumentDB.Models
{
    public class AllergyTopping
    {
        public int Id { get; set; }
        public Allergy Allergy { get; set; }
        //public Topping Topping { get; set; }
    }
}
