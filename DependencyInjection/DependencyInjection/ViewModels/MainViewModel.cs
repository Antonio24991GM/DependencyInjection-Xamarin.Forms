using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DependencyInjection.Models;
using DependencyInjection.Services;

namespace DependencyInjection.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<Employee> _employees;

        public ObservableCollection<Employee> Employees
        {
            get { return _employees; }
            set { _employees = value; }
        }

        public MainViewModel()
        {
            Employees = new ObservableCollection<Employee>();
            var employeeService = new EmployeeService();
            var employeesList = employeeService.GetAllEmployees();

            foreach (var employee in employeesList)
            {
                Employees.Add(employee);
            }
        }
    }
}
