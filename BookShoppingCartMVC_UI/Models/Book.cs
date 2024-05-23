using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingCartMVC_UI.Models
{
    [Table("Book")]
    public class Book
    {
       public int id { get; set; }
        [Required]
        [MaxLength(40)]
        public string? BookName { get; set; }
        [Required]
        [MaxLength(40)]
        public string? AuthorName { get; set; }
        [Required]
        public double Price { get; set; }
        public string? Image { get; set; }
        [Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public List<OrderDetail>orderDetails {  get; set; }
        public List<CartDetail>cartDetails { get; set; }
        [NotMapped]
        public string GenreName {  get; set; }

    }
}
