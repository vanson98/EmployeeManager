using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EmployeeManager.Models;
using EmployeeManager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EmployeeManager.ViewModels
{
    public partial class AppLayoutViewModel : ObservableObject
    {
        [ObservableProperty]
        private object _currentViewModel;

        [ObservableProperty]
        private EmployeeModel? _currentEmployeeDetail;
        
        public AppLayoutViewModel()
        {
            _currentViewModel = new EmployeeListViewModel();
            _currentEmployeeDetail = null;
        }
        
        [RelayCommand]        
        private void MoveToInfoView(EmployeeModel employee)
        {
            CurrentViewModel = new EmployeeInfoViewModel();
            CurrentEmployeeDetail = employee;
        }
        
        [RelayCommand]
        private void MoveToListEmployeeView()
        {
            if (CurrentEmployeeDetail == null)
            {
                return;
            }
            CurrentViewModel = new EmployeeListViewModel();
            CurrentEmployeeDetail = null;
        }
    }
}
