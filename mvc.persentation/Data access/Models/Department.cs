﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_access.Models
{
    public class Department :BaseEntity
    {
        public string Name  { get; set; }=null!;
        public string? Description { get; set; }
        public string Code  { get; set; }=null!;



    }
}
