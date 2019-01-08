using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenPiece.Desktop.Models;
using VenPiece.Desktop.Repository;

namespace VenPiece.Desktop.ViewModels
{
    public class EmployeeListViewModel : BindableBase
    {
        public EmployeeListViewModel()
        {
            LoadEmployees();
        }
        private static readonly VenPieceDbContext dbContext = new VenPieceDbContext();
        private IEmployeeRepository _repository = new EmployeeRepository(dbContext);
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
