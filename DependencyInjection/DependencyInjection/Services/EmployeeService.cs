using System.Collections.Generic;
using DependencyInjection.Models;

namespace DependencyInjection.Services
{
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> GetAllEmployees()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Name = "Josevi",
                    Description = "Description for employee 1"
                },
                new Employee
                {
                    Name = "Gerard",
                    Description = "Description for employee 2"
                },
                new Employee
                {
                    Name = "Lee",
                    Description = "Description for employee 3"
                },
                new Employee
                {
                    Name = "Chris",
                    Description = "Description for employee 4"
                },
                new Employee
                {
                    Name = "Scott",
                    Description = "Description for employee 5"
                },
                new Employee
                {
                    Name = "Sachin",
                    Description = "Description for employee 6"
                }
            };
        }
    }
}
