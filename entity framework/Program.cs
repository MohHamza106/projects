using System.ComponentModel.DataAnnotations;
using entity_framework.entity;
using entity_framework.Models;
using Microsoft.EntityFrameworkCore;

namespace entity_framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region session1
            /*
      // entity framework : object relational mapper (orm) : used to interact between DB
      // used entity framework core as feature support many DB
      // models: class represent table in DB 
      // properties: represent column in table
      //3 way to used entity framework core:
      1 code first
      2: Entity : generate models  According to DB(reverse engineering)
      3: handle code models  to match DB
      __________________________________________
                          entity framework core
      1Dbcontext : center class entity connection between DB and app ( save , change tracker, reterive)
      2: Dbset:collection represent  table by model 
      3: change tracker: EN automatic tracker change to entity update call when used method (save changes())
      4: migrations:
      _________________________________
      ____________________________ way to mapping _____________

      1:by convention : default convention to map classes to DB table
      2:dataAnnotation
      3:fluent API
      */
            #endregion
            #region session2
            /*
             _______ fluent API________
            way to configure  propreties entity , relation
            used to full control DB schema
             defind meethod name  OnModelCreating in DBcontext

             */
            #endregion
            #region query object model
            using CompanyDbContext companyDbContext = new CompanyDbContext();

            #region add row in database 4 way- insert
            //Employee employee1 = new Employee()
            //{
            //    Id = 0,
            //    FirstName = " ahmed",
            //    LastName = "ali",
            //    Address = "Alex",
            //    Email = "ahmedali@gmail.com",
            //    Phone = "10205679",
            //    Country = "mohhjhq",
            //    Name = "mohamed",
            //    PhoneNumber = "1561"

            //};
            //Console.WriteLine(companyDbContext.Entry<Employee>(employee1).State);
            ////keyword required : ensure not null value in compilation time:  required
            ////  [required] attribute: validation a required  value in run time 
            //companyDbContext.Add(employee1);
            //companyDbContext.Set<Employee>().Add(employee1);
            //companyDbContext.employee.Add(employee1);
            //companyDbContext.Entry<Employee>(employee1).State= EntityState.Added;
            //Console.WriteLine(companyDbContext.Entry<Employee>(employee1).State);

            //Console.WriteLine($"employee1.Id:{employee1.Id}");
            //companyDbContext.SaveChanges();
            //Console.WriteLine("after changes");
            //Console.WriteLine(companyDbContext.Entry<Employee>(employee1).State);

            //Console.WriteLine($"employee1.Id:{employee1.Id}");
            #endregion
            #region retrieve data  from table in database - select
            //var emp1 = companyDbContext.employee.FirstOrDefault(e=>e.Id==9);
            //if (emp1  is not  null)
            //{
            //    Console.WriteLine(companyDbContext.Entry<Employee>(emp1).State);
            //    Console.WriteLine($"{emp1.Id}/{emp1.LastName}");
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}
            //var emp2 = companyDbContext.employee.AsTracking().FirstOrDefault(e=>e.Id==10);
            //emp2.Name = "ail";
            //companyDbContext.SaveChanges();
            //Console.WriteLine(companyDbContext.Entry<Employee>(emp2).State);

            #endregion
            #region update data from database
            //var emp1 = companyDbContext.employee.FirstOrDefault(e => e.Id == 9);
            //if (emp1 is not null)
            //{
            //    Console.WriteLine(companyDbContext.Entry<Employee>(emp1).State);

            //    Console.WriteLine($"{emp1.Id}/{emp1.PhoneNumber}");
            //    Console.WriteLine("after changes");
            //    emp1.PhoneNumber = "123456789";
            //    companyDbContext.SaveChanges(); 
            //    Console.WriteLine(companyDbContext.Entry<Employee>(emp1).State);

            //    Console.WriteLine($"{emp1.Id}/{emp1.PhoneNumber}");

            //}

            //else
            //{
            //    Console.WriteLine(false);
            //}
            #endregion
            #region remove data from table in database 4way to delete
            //var emp1 = companyDbContext.employee.FirstOrDefault(e => e.Id == 11);
            //if (emp1 is not null)
            //{
            //    Console.WriteLine(companyDbContext.Entry<Employee>(emp1).State);//state is Detached

            //    Console.WriteLine($"{emp1.Id}/{emp1.PhoneNumber}");
            //    Console.WriteLine("after changes");
            //    companyDbContext.employee.Remove(emp1);
            //    companyDbContext.Remove(emp1);
            //    companyDbContext.Set<Employee>().Remove(emp1);
            //    companyDbContext.Entry<Employee>(emp1).State= EntityState.Deleted;//state is delete
            //    companyDbContext.SaveChanges();
            //    Console.WriteLine(companyDbContext.Entry<Employee>(emp1).State);//after save changes state is Detached

            //    Console.WriteLine($"{emp1.Id}/{emp1.PhoneNumber}");

            //}

            //else
            //{
            //    Console.WriteLine(false);
            //}
            #endregion
            #endregion
            #region data seeding
            //way to deploye or insert  data in DB 
            // when create database  is null 
            // 3 way to handle data seeding
            // used when two  table depend on db
            #region manual data seeding 
            //not use
            //Department department = new Department() { Name="HR"};
            //companyDbContext.Set<Department>().Add(department);
            //companyDbContext.SaveChanges();
            //List<Department> departmentList = new List<Department>()
            //{
            //    new Department(){Name="hr"},
            //    new Department(){Name="HR"}


            //};
            //companyDbContext.Set<Department>().AddRange(departmentList);
            //companyDbContext.SaveChanges();

            #endregion
            #region using migration
            // use function has data in model creation
            #endregion





            #endregion



        }
    }
}
