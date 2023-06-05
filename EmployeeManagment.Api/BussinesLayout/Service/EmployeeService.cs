using EmployeeManagment.Api.BussinesLayout.Data;
using EmployeeManagment.Api.BussinesLayout.Interfaces;
using EmployeeManagment.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.Api.BussinesLayout.Service
{
    public class EmployeeService : IEmployeeRepository
    {
        private readonly EmployeeDbContext _context;

        public EmployeeService(EmployeeDbContext context)
        {
            _context = context;
        }
        public async Task<Employee> CreateEmployeeAsync(Employee employee)
        {
            try
            {
                Employee createEmployee = new Employee();
                {
                    Department department = new Department();

                    if (employee.Department != null)
                    {
                        department = new Department()
                        {
                            DepartmentName = employee.Department.DepartmentName
                        };

                        await _context.Departments.AddAsync(department);
                        await _context.SaveChangesAsync();
                    }

                    createEmployee.FirstName = employee.FirstName;
                    createEmployee.LastName = employee.LastName;
                    createEmployee.Email = employee.Email;
                    createEmployee.DateOfBirth = employee.DateOfBirth;
                    createEmployee.Gender = employee.Gender;
                    createEmployee.Roles = employee.Roles;
                    createEmployee.PhotoPath = employee.PhotoPath;
                    createEmployee.Department = department;

                    await _context.Employees.AddAsync(createEmployee);
                    await _context.SaveChangesAsync();
                }


                return employee;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async void DeleteEmployeeByIdAsync(int id)
        {
            try
            {
                var employee = await _context.Employees.FindAsync(id);
                if (employee != null)
                {
                    _context.Employees.Remove(employee);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            try
            {
                List<Employee> employees = await _context.Employees.ToListAsync();

                return employees;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            try
            {
                var employee = await _context.Employees.FindAsync(id);

                return employee;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Employee> UpdateEmployeeAsync(Employee employee)
        {
            try
            {
                //Employee findEmployee = await _context.Employees.FindAsync(employee.EmployeeId);
                //if (findEmployee != null)
                //{
                //    findEmployee.FirstName = employee.FirstName;
                //    findEmployee.LastName = employee.LastName;
                //    findEmployee.Email = employee.Email;
                //    findEmployee.DateOfBirth = employee.DateOfBirth;
                //    findEmployee.Gender = employee.Gender;
                //    findEmployee.Roles = employee.Roles;
                //    findEmployee.Department = employee.Department;
                //    findEmployee.PhotoPath = employee.PhotoPath;
                //}
                _context.Update(employee);
                await _context.SaveChangesAsync();

                return employee;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
