using EmployeeManagment.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace EmployeeManagment.Models
{
    [Table("Employee")]
    public class Employee
    {
        public int EmployeeId { get; set; } //PK
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Roles Roles { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }
    }
}