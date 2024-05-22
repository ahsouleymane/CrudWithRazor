using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CrudWithRazor.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Nom Produit")]
        public string ProductName { get; set; }
        [Required]
        [DisplayName("Prix")]
        public double Price { get; set; }
        [DisplayName("Quantité")]
        public int Qty { get; set; }
    }
}
