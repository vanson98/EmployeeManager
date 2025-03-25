using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EmployeeManager.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.ViewModels
{
    public partial class EmployeeInfoViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _employeeInfoTabMode = "PersonalInfo";

        [ObservableProperty]
        private object _currentTabViewModel;

        public EmployeeInfoViewModel()
        {
            _currentTabViewModel = new EmployeeUpdateFormViewModel();
        }

        [RelayCommand]
        public void ViewChartComponent()
        {
            CurrentTabViewModel = new EmployeeChartViewModel();
        }

        [RelayCommand]
        public void ViewUpdateFormComponent()
        {
            CurrentTabViewModel = new EmployeeUpdateFormViewModel();
        }
    }
}
