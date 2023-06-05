using EmployeeManagment.Blazor.DataAccess_Blazor.Interfaces;
using EmployeeManagment.Models;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagment.Blazor.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeRepositoryBlazor EmployeeRepositoryBlazor { get; set; }
        public IEnumerable<Employee> Employees { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeRepositoryBlazor.GetAllEmployeesBlazorAsync()).ToList();
        }
    }
}
