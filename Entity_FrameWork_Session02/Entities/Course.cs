using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Session02.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        public int Duration { get; set; }
        public string? Description { get; set; }
        [ForeignKey("Topic_Id")]
        public int? Top_Id { get; set; }
        [InverseProperty("Courses")]
        public Topic Topic_Id { get; set; }
        public ICollection<Stud_Course> Course_Students { get; set; } = new HashSet<Stud_Course>();
        public ICollection<Course_Inst> Course_Insts { get; set; } = new HashSet<Course_Inst>();
    }
}
