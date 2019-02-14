using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameTest.Model
{
    [Table("StudentInfo",Schema = "Admin")]
    public class Student
    {
        [Key]
        public int SID { get; set; }
        [Column("Name",TypeName = "nText")]
        [MaxLength(20)]
        public string StudentName { get; set; }
        [NotMapped] // this property will not be saved on db
        public int? Age { get; set; }
        public string City // this property will not be saved on db because does not have both get and set
        {
            get { return StudentName; }
        }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }

        public Grade Grade { get; set; }
        [ForeignKey("Standard")] //foreign key to Standard table 
        public int StandardRefId { get; set; }

        public Standard Standard { get; set; }


    }
    
}
