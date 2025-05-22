using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using entity_framework.Modelconfiguration;
using entity_framework.Models;
using Microsoft.EntityFrameworkCore;

namespace entity_framework.entity
{
    internal class CompanyDbContext:DbContext
    {
        public DbSet<Employee> employee {  get; set; }
        public DbSet<student> student { get; set; }
        public DbSet<course> course { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; database= CompanyDb;Integrated Security=True;Trusted_Connection=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region MyRegion
            //modelBuilder.Entity<Employee>().HasKey(e=>e.Id);
            //modelBuilder.Entity<Employee>()
            //    .Property(e => e.Name)
            //    .HasColumnName("employee_name")
            //    .HasColumnType("varchar")
            //    .HasMaxLength(100)// varchar(100)
            //    .IsRequired( false);// allow null



            //    modelBuilder.Entity<Employee>().Property(nameof(Employee.Name));
            //    modelBuilder.Entity<Employee>().Property("name");// throw exception
            #endregion
            #region one to one
            //when class name Employee configuration create to take all model
            //ex1
            //modelBuilder.ApplyConfiguration<Employee>(new EmpolyeeConfiguration());
            // other best way as when write auther configuration  dont call for ex1
            // automatically apply all fluent api configuration  from ExecutingAssembly
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.Entity<Employee>()
            //    .HasOne(e => e.manger_department)
            //    .WithOne(e => e.manger);
            //modelBuilder.Entity<Department>()
            //    .HasOne(d => d.manger)
            //    .WithOne(d => d.manger_department)
            //    .HasForeignKey<Department>(d => d.manger_id);
            #endregion
            #region one to many
            //modelBuilder.Entity<Employee>()
            //    .HasOne(e => e.EMployeeDepatment)
            //    .WithMany(d => d.employees)
            //    .HasForeignKey(e => e.dep_id)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Department>()
            //    .HasMany(d => d.employees)
            //    .WithOne(e => e.EMployeeDepatment)
            //    .HasForeignKey(e=>e.dep_id);



            #endregion
            #region many to many
            #region if no attribute in relation
            //modelBuilder.Entity<student>()
            //    .HasMany(s => s.courses)
            //    .WithMany(c => c.students)
            //    .UsingEntity(resulttable => resulttable.ToTable("student_Course"));
            #endregion
            #region if relation take   attribute
            modelBuilder.Entity<student>()
                .HasMany(s => s.student_Courses)
                .WithOne(st_co => st_co.students)
                .HasForeignKey(sc => sc.Stu_Id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<course>()
            .HasMany(c => c.Course_Student)
            .WithOne(st_co => st_co.courses)
            .HasForeignKey(sc => sc.Cour_Id)
            .OnDelete(DeleteBehavior.NoAction);

            #endregion

            #endregion

        }
    }
}
