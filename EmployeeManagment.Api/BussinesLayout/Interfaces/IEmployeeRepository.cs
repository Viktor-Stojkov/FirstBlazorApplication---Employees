using EmployeeManagment.Models;

namespace EmployeeManagment.Api.BussinesLayout.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task<Employee> CreateEmployeeAsync(Employee employee);
        Task<Employee> UpdateEmployeeAsync(Employee employee);
        void DeleteEmployeeByIdAsync(int id);

    }
}
