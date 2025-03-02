using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Session02.Entities
{
    internal class Instructor
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public float Salary { get; set; }
        [Required]
        [MaxLength(30)]
        public string Address { get; set; }
        [Required]
        public float HourRate { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public float Bonus { get; set; }

        [ForeignKey("Department_Id")]
        public int? Dept_Id { get; set; }
        [InverseProperty("Instructors")]
        public Department Department_Id { get; set; }
        //[InverseProperty("Manager")]
        //public Department Department { get; set; }
        public ICollection<Course_Inst> Inst_Courses { get; set; } = new HashSet<Course_Inst>();
    }
}
