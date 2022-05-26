using System.ComponentModel.DataAnnotations;

namespace OrderManagement.Models
{
    public class OrderCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
    }
}
