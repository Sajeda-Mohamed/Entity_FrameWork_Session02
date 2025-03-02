using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entity_FrameWork_Session02.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(20, MinimumLength = 3)]
        public string FName { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(20, MinimumLength = 3)]
        public string LName { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        //[StringLength(20, MinimumLength = 3)]
        [MaxLength(30)]
        public string Address { get; set; }
        [Required]
        [Range(18, 50)]
        public int Age { get; set; }
        [ForeignKey("department_Id")]
        public int? Dept_Id { get; set; }
        [InverseProperty("Students")]
        public Department department_Id { get; set; }
        public ICollection<Stud_Course> Stud_Courses { get; set; } = new HashSet<Stud_Course>();
    }
}
