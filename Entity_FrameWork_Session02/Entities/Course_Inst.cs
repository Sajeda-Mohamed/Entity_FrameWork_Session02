using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Session02.Entities
{
    internal class Course_Inst
    {
        [ForeignKey("Instructor")]
        public int Inst_Id { get; set; }
        [ForeignKey("Course")]
        public int Course_Id { get; set; }
        [Required]
        public string Evaluate { get; set; }
        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
    }
}
