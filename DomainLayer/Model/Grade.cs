using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DomainLayer.Models;

namespace DomainLayer.Model
{

  
    public class Grade : BaseEntity
    {
        
        [Key]
        public int GradeId { get; set; }
        [Required(ErrorMessage = "Grade name is required", AllowEmptyStrings = false)]
        public string GradeName { get; set; }

        [Required(ErrorMessage = "Grade point required", AllowEmptyStrings = false)]
        public double GradePoint { get; set; }

        [Required(ErrorMessage = "Range from required", AllowEmptyStrings = false)]
        public int ScoreFrom { get; set; }

        [Required(ErrorMessage = "Range to required", AllowEmptyStrings = false)]
        public int ScoreTo { get; set; }


        //public virtual ICollection<StudentEnrollment> StudentEnrollments { get; set; }

    }
}
