using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_framework.Models
{
    internal class student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null;
        public int Age { get; set; }
        //if no attribute in relation
        //[InverseProperty (nameof(course.students))]
        //public ICollection<course> courses { get; set; } = new HashSet<course>();
        // if relation take   attribute
        [ForeignKey(nameof(Student_Course.Stu_Id))]
        [InverseProperty(nameof(Student_Course.students))]
        public ICollection<Student_Course> student_Courses { get; set; } = new HashSet<Student_Course>();


    }
}
