using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Session02.Entities
{
    internal class Stud_Course
    {
        [ForeignKey("Student")]
        public int Stud_Id { get; set; }
        [ForeignKey("Course")]
        public int Course_Id { get; set; }
        [Required]
        [MaxLength(100)]
        public float Grade { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
