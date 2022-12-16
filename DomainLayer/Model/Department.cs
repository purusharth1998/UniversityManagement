using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DomainLayer.Models
{
    public class Department : BaseEntity
    {
        [Key]
        public int Id { get; set; }
       
        public string DepartmentName { get; set; }
        public int DepartmentId { get; set; }
        //[DisplayName("Student")]
        //[Required(ErrorMessage = "Please! Select related Student!")]
        //[ForeignKey("StudentId")]
        //public int StudentId { get; set; }

        //public virtual Student Students { get; set; }

    }
}