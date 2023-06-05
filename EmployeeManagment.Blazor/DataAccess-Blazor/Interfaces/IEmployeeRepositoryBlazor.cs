using EmployeeManagment.Models;

namespace EmployeeManagment.Blazor.DataAccess_Blazor.Interfaces
{
    public interface IEmployeeRepositoryBlazor
    {
        Task<IEnumerable<Employee>> GetAllEmployeesBlazorAsync();

    }
}
