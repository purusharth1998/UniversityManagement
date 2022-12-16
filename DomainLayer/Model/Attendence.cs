using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Model
{
    public class Attendence : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime? AttendenceDate { get; set; }
        [ForeignKey("StudentId")]
        public int StudentId { get; set; }
        [ForeignKey("CourseCode")]
        public string Code { get; set; }
        public bool Ispresent {get;set;}

    }
}
