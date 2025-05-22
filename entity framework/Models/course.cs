using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_framework.Models
{
    internal class course
    {
        public int Id { get; set; }
        public string Title { get; set; } = null;
        //if no attribute in relation
        //[InverseProperty(nameof(student.courses))]
        //public ICollection<student> students { get; set; }= new HashSet<student>();
        // if relation take   attribute
        [ForeignKey(nameof(Student_Course.Cour_Id))]
        [InverseProperty(nameof(Student_Course.courses))]
        public ICollection<Student_Course>  Course_Student { get; set; } = new HashSet<Student_Course>();

    }
}
