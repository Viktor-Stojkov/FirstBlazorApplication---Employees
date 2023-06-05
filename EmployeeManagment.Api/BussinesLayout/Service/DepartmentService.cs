using EmployeeManagment.Api.BussinesLayout.Data;
using EmployeeManagment.Api.BussinesLayout.Interfaces;
using EmployeeManagment.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.Api.BussinesLayout.Service
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
