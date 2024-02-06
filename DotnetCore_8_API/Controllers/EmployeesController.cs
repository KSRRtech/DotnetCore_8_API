using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAppSample.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreAppSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: api/Employees
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            var employeeNames = _employeeService.GetEmployees();
            return employeeNames;
        }

        // GET: api/Employees/5
        [HttpGet("{id}", Name = "GetEmployeesById")]
        public Employee GetEmployeesById(int id)
        {
            var employee = _employeeService.GetEmployeesById(5);
            return employee;
        }

        // POST: api/Employees
        [HttpPost]
        public Employee Post([FromBody] Employee employee)
        {
            var newemp = _employeeService.AddEmployee(employee);
            return newemp;
        }

        // PUT: api/Employees/5
        [HttpPut("{id}")]
        public List<Employee> Put(int id, [FromBody] Employee employee)
        {
            var emp = _employeeService.EditEmployee(employee);
            return emp;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
