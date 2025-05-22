using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Solution_assignment
{
    public enum Gender
    {
        M,
        F
    }
    public enum security
    {
        guest=1, Developer=2, secretary=4, DBA=8
    }
    internal class Employee
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public security security_level { get; set; }
        public int salary { get; set; }
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public Gender gender { get; set; }


        public Employee(int iD, string name, security security_level, int salary, int day, int month,int year, Gender gender)
        {
            ID = iD;
            Name = name;
            this.security_level = security_level;
            this.salary = salary;
            this.day = day;
            this.month = month;
            this.year = year;
            this.gender = gender;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Id: {ID},salary:{salary:c},Data{day}/{month}/{year}, gender:{gender}";

        }
    }
}
