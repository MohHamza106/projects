using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_framework.Models
{
    internal class Department
    {
        public int? depId { get; set; }
        public string Name { get; set; } = null;
        public string Description { get; set; } = string.Empty;
        public string Type { get; set; }= string.Empty;
        #region one to one
        [ForeignKey(nameof(manger))]
        public int? manger_id { get; set; }
        //one to one
        [InverseProperty(nameof(Employee.manger_department))]
        public Employee manger { get; set; } = null;
        #endregion

        #region one to many
        //one to many

        // use ICollection  to many feature later than IEnumerable
        //initilized or  use constrains   to create object to take data
        [InverseProperty(nameof(Employee.EMployeeDepatment))]
        public ICollection<Employee> employees { get; set; } = new List<Employee>();
        // use HashSet to ensure data is unique
        // use constrains   to create object to take data
        //public Department()
        //{
        //    work_emp = new HashSet<Employee>();
        //}
        #endregion

    }
}
