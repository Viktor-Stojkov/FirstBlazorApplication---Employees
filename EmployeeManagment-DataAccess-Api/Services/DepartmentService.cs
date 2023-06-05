using EmployeeManagment.Models;
using EmployeeManagment_DataAccess_Api.Date;
using EmployeeManagment_DataAccess_Api.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment_DataAccess_Api.Services
{
    public class DepartmentService : IDepartmentRepository
    {
        private readonly EmployeeDbContext _context;

        public DepartmentService(EmployeeDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Department>> GetAllDepartmentAsync()
        {
            try
            {
                List<Department> departments = await _context.Departments.ToListAsync();
                return departments;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Department> GetDepartmentByIdAsync(int id)
        {
            try
            {
                var department = await _context.Departments.FindAsync(id);

                return department;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
