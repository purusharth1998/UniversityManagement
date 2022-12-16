using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DomainLayer.Models;

namespace DomainLayer.Model
{
    public class Teacher : BaseEntity
    {
        public int TeacherId { get; set; }
        [Required(ErrorMessage = "Teacher name is required", AllowEmptyStrings = false)]
        public string TeacherName { get; set; }

        [Required(ErrorMessage = "Birthdate is required", AllowEmptyStrings = false)]
        public string BirthDate { get; set; }

        [Required(ErrorMessage = "Salary is required", AllowEmptyStrings = false)]
        public double Salary { get; set; }
     
    }


}

