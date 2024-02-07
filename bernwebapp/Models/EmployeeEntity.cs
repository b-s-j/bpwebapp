using System.ComponentModel.DataAnnotations;

namespace bernwebapp.Models
{
    public class EmployeeEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Position { get; set; }
        public int EmployeeId { get; set; } = 0;

        public string Office { get; set; }

        [Required]
        public int Salary { get; set; }

        public string Image { get; set; }
        public string Email { get; set; }
    }


}
