using Identity.Assignments;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Identity.Assignments

{
    [Table("FileDetails")]
    public class FileDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
        //public FileType FileType { get; set; }
    }
}