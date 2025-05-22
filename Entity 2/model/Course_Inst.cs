using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_2.model
{
    internal class Course_Inst
    {
        [Key]
        public int ins_ID { get; set; } //relation
        public int Course_Id { get; set; }//relation
        public string Evaluate { get;set; }


    }
}
