using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppSample.Services
{
    public interface IEmployeeService
    {
        List<string> GetEmployeeNames();
        List<Employee> GetEmployees();
        Employee GetEmployeesById(int id);
        Employee AddEmployee(Employee emp);
        List<Employee> EditEmployee(Employee emp);
    }
}
