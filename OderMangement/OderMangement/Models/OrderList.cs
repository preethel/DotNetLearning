using System.ComponentModel.DataAnnotations;

namespace OderMangement.Models
{
    public class OrderList
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }

    }
}
