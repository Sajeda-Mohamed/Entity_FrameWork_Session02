using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Session02.Entities
{
    internal class Stud_Course
    {
        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }
        [Required]
        [MaxLength(100)]
        public float Grade { get; set; }
    }
}
