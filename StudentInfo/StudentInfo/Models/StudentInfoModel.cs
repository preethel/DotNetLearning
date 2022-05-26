using System.ComponentModel.DataAnnotations;

namespace StudentInfo.Models
{
    public class StudentInfoModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter your Name")]
        [Display(Name = "Name")]
        public string StudentName { get; set; }
        [Required(ErrorMessage ="Please enter your Id")]
        [Display(Name ="Student Id")]
        public string StdId { get; set; }
        [Required(ErrorMessage ="Please enter a valid Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please enter your Department")]
        public string Department { get; set; }
    }
}
