using System.ComponentModel.DataAnnotations;

namespace TodoApps.Models
{
    public class TodoList
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartedTime { get; set; } = DateTime.Now;
        public DateTime EndTime { get; set; }
    }
}
