using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingCartMVC_UI.Models
{
    [Table("Order")]
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public DateTime CreateDate { get; set; }= DateTime.Now;
        [Required]
        public int OrderStatus { get; set; }
        public bool IsDeleted { get; set; } = false;
        public OrderStatus orderStatus { get; set; }
        public List<OrderDetail>orderDetails { get; set; }

    }
}
