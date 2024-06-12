using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_pr1
{
    public class ApplicationType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Name length can't be more than 15.")]
        public string Name { get; set; }
    }
}