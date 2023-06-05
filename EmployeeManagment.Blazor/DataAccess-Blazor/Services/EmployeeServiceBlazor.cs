using EmployeeManagment.Blazor.DataAccess_Blazor.Interfaces;
using EmployeeManagment.Models;

namespace EmployeeManagment.Blazor.DataAccess_Blazor.Services
{
    public class EmployeeServiceBlazor : IEmployeeRepositoryBlazor
    {
        private readonly HttpClient _httpClient;

        public EmployeeServiceBlazor(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Employee>> GetAllEmployeesBlazorAsync()
        {
            return await _httpClient.GetFromJsonAsync<Employee[]>("api/employee");
        }
    }
}
