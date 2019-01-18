using System.ComponentModel.DataAnnotations.Schema;

namespace MvcTest.Models
{

    [Table("product")]
    public class Product
    {
        public int Id {get; set;}

        public string Name {get; set;}

        public double Price {get; set;}

        public int Quantity {get; set;}

        public bool Status {get; set;}
    }
}