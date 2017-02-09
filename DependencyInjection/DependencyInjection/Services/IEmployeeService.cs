using System.Collections.Generic;
using DependencyInjection.Models;

namespace DependencyInjection.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
    }
}