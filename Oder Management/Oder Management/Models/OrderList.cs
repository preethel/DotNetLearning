using System.ComponentModel.DataAnnotations;

namespace Oder_Management.Models
{
    public class OrderList
    {
        [Key]
        public int Id { get; set; }
        public string OrderTitle { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }

    }
}
