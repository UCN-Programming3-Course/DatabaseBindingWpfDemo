using DataAccessLayer;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBindingWpfDemo.ViewModels
{
    class EditEmployeeViewModel
    {
        private readonly IRepository<Employee> _employeeRepository;
        private readonly IRepository<Department> _departmentRepository;

        public EditEmployeeViewModel()
        {
            _employeeRepository = RepositoryFactory<Employee>.Create();
            _departmentRepository = RepositoryFactory<Department>.Create();
        }

        public IEnumerable<Employee> Employees => _employeeRepository.GetAll(); 

        public IEnumerable<Department> Departments => _departmentRepository.GetAll();
    }
}
