using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_2.model;
using Microsoft.EntityFrameworkCore;

namespace Entity_2.entityContext
{
    internal class CompanyDbcontext:DbContext
    {
        #region Dbset
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<Stud_Course> stud_Courses { get; set; }
        public DbSet<Course_Inst > course_Insts { get; set; }


        #endregion


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-OS606SR\\MSSQLSERVER01;Integrated Security=True;Connect Timeout=30;Encrypt=false;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         modelBuilder.Entity<Student>().HasKey(Student => Student.Id);
            modelBuilder.Entity<Student>().Property(s => s.FName)
                .HasColumnName("first_name")
                .HasColumnType("string")
                .HasDefaultValue("mohamed")
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Department>(d =>
            {
                d.ToTable("department", "sales");
                d.HasKey(d => d.Id);
                d.Property(d => d.Name).HasConversion(typeof(string));
            });
          
        }
    }
}