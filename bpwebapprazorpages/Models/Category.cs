using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace bpwebapprazorpages.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Category Name")]
        [MaxLength(50)]
        public string? Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be 1 to 100 only.")]
        public int DisplayOrder { get; set; }



    }
}
