using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppSample.Services
{
    public class EmployeeService : IEmployeeService
    {
        public List<string> GetEmployeeNames()
        {
            return new List<string> { "peter", "parker" };
        }

        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>() {
                new Employee { EID=1,EName="name1",City="London"},
                new Employee { EID=2,EName="name2",City="NY"},
                new Employee { EID=3,EName="name3",City="Florida"},
                new Employee { EID=4,EName="name4",City="Liverpool"},
                new Employee { EID=5,EName="name5",City="Wales"},
                new Employee { EID=6,EName="name6",City="London"}
                };
            return employees;
        }

        public Employee GetEmployeesById(int id)
        {
            var emp = GetEmployees().Where(e => e.EID == id)?.FirstOrDefault();
            return emp;
        }


        public Employee AddEmployee(Employee emp)
        {

            var employees = GetEmployees();
            employees.Add(emp);

            var newEmp = employees.Where(e => e.EID == emp.EID)?.FirstOrDefault();
            return newEmp;

        }

        public List<Employee> EditEmployee(Employee emp)
        {
            //var employees = GetEmployees();
            //employees.Add(emp);

            var editedEmp = GetEmployees();
            return editedEmp;
        }
    }
}
