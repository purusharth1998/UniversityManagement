using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DomainLayer.Models
{
    public class Course:BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a valid course code!")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Code must be contains 5 characters!")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Please enter a valid course name!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a valid Course credit!")]
        [Range(0.5, 5.00, ErrorMessage = "Credit must be betwwen 0.5 and 5.00")]
        public double Credit { get; set; }
        [Required(ErrorMessage = "Please write course description!")]
        public string Description { get; set; }
        //[DisplayName("Student")]
        //[Required(ErrorMessage = "Please! Select related Student!")]
        [ForeignKey("StudentId")]
        public int StudentId { get; set; }

        //public virtual Student Students { get; set; }

    }
}