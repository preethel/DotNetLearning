using System.ComponentModel.DataAnnotations;

namespace TodoApps.Models
{
    public class TodoModel
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime EndTime { get; set; }
    }
}
