using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_2.model
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public int Bouns { get; set; }
        public DateTime HourDate { get; set; }
        public  int  Dept_Id { get; set; } //relation

    }
}
