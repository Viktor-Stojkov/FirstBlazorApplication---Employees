using EmployeeManagment.Models;
using EmployeeManagment_DataAccess_Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            try
            {
                return Ok(await _employeeRepository.GetAllEmployeesAsync());

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetEmployeeById(int id)
        {
            try
            {
                var getEmployeeById = await _employeeRepository.GetEmployeeByIdAsync(id);

                if (getEmployeeById == null)
                    return RedirectToAction(nameof(Index));

                return Ok(getEmployeeById);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<ActionResult> CreateEmployee(Employee employee)
        {
            try
            {
                if (employee == null)
                    return BadRequest();

                var createEmployee = await _employeeRepository.CreateEmployeeAsync(employee);
                return CreatedAtAction(nameof(CreateEmployee), new { id = createEmployee.EmployeeId }, createEmployee);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
