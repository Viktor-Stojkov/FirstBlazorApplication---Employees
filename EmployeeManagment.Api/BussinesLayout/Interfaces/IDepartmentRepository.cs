using EmployeeManagment.Models;

namespace EmployeeManagment.Api.BussinesLayout.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetAllDepartmentAsync();
        Task<Department> GetDepartmentByIdAsync(int id);
    }
}
