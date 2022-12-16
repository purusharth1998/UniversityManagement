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
    public class Student : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        
        public string? Name { get; set; }
        
        public string? Address { get; set; }
        
        public string? Emial { get; set; }
        
        public string? City { get; set; }
        
        public string? State { get; set; }
       
        public string? Country { get; set; }
       
        public int? Age { get; set; }
        public int StudentId { get; set; }
        [DisplayName("Department")]
        [Required(ErrorMessage = "Please! Select related department!")]
        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        //public virtual Department Departments { get; set; }

        public DateTime? BirthDate { get; set; }
        //[DisplayName("Course")]
        //[Required(ErrorMessage = "Please! Select related Course!")]
        //[ForeignKey("CourseId")]
        //public int CourseId { get; set; }
        //public virtual Course Courses { get; set; }
    }
}