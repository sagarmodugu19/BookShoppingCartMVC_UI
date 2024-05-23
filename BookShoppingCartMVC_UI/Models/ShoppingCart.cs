using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingCartMVC_UI.Models
{
    [Table("ShoppingCart")]
    public class ShoppingCart
    {
        public int id { get; set; }
        [Required]
        public string UserId { get; set; }
        public bool IsDeleted { get; set; }=false;
        public ICollection<CartDetail> cartDetails { get; set; }

    }
}
