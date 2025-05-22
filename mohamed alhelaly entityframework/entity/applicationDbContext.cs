using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mohamed_alhelaly_entityframework.entity
{
    internal class applicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=>
        
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-OS606SR\\MSSQLSERVER01;Integrated Security=True");
         public DbSet<EMployee> Employees { get; set; }
    }
}
