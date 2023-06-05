using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment.Models
{
    [Table("Department")]
    public class Department
    {
        public int DepartmentId { get; set; } //PK
        public string DepartmentName { get; set; }
    }
}
