using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace entity_framework.Models
{
    //when relationship of one to one  all mandatory used owend 
    //[Owned]
    internal class Address
    {
     
        public int id { get; set; }
        public string City { get; set; }
        public string country { get; set; }
        public string street { get; set; }


    }
}
