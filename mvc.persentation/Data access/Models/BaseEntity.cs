using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_access.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }// pk
        public int CreateBy { get; set; }//userId
        public DateTime CreateOn { get; set; }//
        public int LastModifiedBy { get; set; }//userId
        public DateTime LastModifiedon { get; set; }//last modified time 
        public bool IsDeleted { get; set; }//soft delete


    }
}
