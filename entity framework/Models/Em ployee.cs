using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_framework.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string Address { get; set; }
        [Required]
        public string? Country { get; set; }
        public required string PhoneNumber { get; set; }

        //one to one 
        [InverseProperty(nameof(Department.manger))]
        public Department?  manger_department { get; set; }
        public Address  empaddress { get; set; }
        //one to many
        // if many relation Ship
        [ForeignKey(nameof(EMployeeDepatment))]
        public int dep_id { get; set; }
        [InverseProperty(nameof(Department.employees))]
        public Department EMployeeDepatment { get; set; }
     



    }
}
