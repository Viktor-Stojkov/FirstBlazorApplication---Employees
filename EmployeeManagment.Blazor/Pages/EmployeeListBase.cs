using EmployeeManagment.Models;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagment.Blazor.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }


        // hard codding

        //protected override async Task OnInitializedAsync()
        //{
        //    await Task.Run(LoadEmployees);

        //    //LoadEmployees();
        //    //return base.OnInitializedAsync();
        //}
        //private void LoadEmployees()
        //{
        //    System.Threading.Thread.Sleep(3000);
        //    //Employee e1 = new Employee()
        //    //{
        //    //    PhotoPath = "images/test.png" /*- kreiran folder vo wwwroot - Blazor*/
        //    //};

        //    Employees = new List<Employee>();
        //}
    }
}
