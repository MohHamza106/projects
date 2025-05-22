using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace entity_framework.Models
{
    [PrimaryKey(nameof(Stu_Id),nameof(Cour_Id))]
    internal class Student_Course
    {
        public int Stu_Id { get; set; }
        public int Cour_Id { get; set; }
        public int Grade { get; set; }
        [InverseProperty(nameof(student.student_Courses))]
        public  student  students { get; set; }
        [InverseProperty(nameof(course.Course_Student))]
        public  course  courses { get; set; }


    }
}
