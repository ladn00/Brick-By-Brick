using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_pr1
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage ="Display Order for category must be greater then 0")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}

