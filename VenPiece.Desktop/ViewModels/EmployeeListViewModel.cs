using System.Collections.ObjectModel;
using VenPiece.Data;
using VenPiece.Data.Models;
using VenPiece.Data.Repository;

namespace VenPiece.Desktop.ViewModels
{
    public class EmployeeListViewModel : BindableBase
    {
        public EmployeeListViewModel(IEmployeeRepository employeeRepository)
        {
            _repository = employeeRepository;
            LoadEmployees();
        }
        private IEmployeeRepository _repository ;
        private ObservableCollection<Employee> _employees;

        public ObservableCollection<Employee> Employees
        {
            get { return _employees; }
            set { SetProperty(ref _employees, value); }
        }

        public async void LoadEmployees()
        {
            Employees = new ObservableCollection<Employee>(await _repository.GetEmployeesAsync());
        }
    }
}
