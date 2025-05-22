using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_2.model
{
    internal class Stud_Course
    {
        [Key] 
        public int Student_Id { get; set; } //relation
        public int tCourse_Id { get; set; }//relation
        public int Grade { get; set; }
    }
}
