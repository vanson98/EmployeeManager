using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EmployeeManager.Components;
using EmployeeManager.Models;
using EmployeeManager.Models.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.ViewModels
{
    public partial class EmployeeInfoViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<EmployeeModel> _employees;
        
        [ObservableProperty]
        private ObservableCollection<EmployeeModel> _filterEmployees;

        [ObservableProperty]
        private object _currentTabViewModel;

        [ObservableProperty]
        private string _currentTabListBox = "All"; 

        public EmployeeInfoViewModel()
        {
            _currentTabViewModel = new EmployeeUpdateFormViewModel();
        }

        [RelayCommand]
        private void ViewChartComponent()
        {
            CurrentTabViewModel = new EmployeeChartViewModel();
        }

        [RelayCommand]
        private void ViewUpdateFormComponent()
        {
            CurrentTabViewModel = new EmployeeUpdateFormViewModel();
        }
        
        [RelayCommand]
        private void FilterEmployeeTabList(string tab)
        {
            if(tab == "Team")
            {
                FilterEmployees = [..Employees.Where(e=>e.Role == EmployeeRole.Developer || e.Role == EmployeeRole.Tester)];
                CurrentTabListBox = "Team";
                return;
            }
            else if(tab == "Leader")
            {
                FilterEmployees = [.. Employees.Where(e => e.Role == EmployeeRole.Designer)];
                CurrentTabListBox = "Leader";
                return;
            }
            FilterEmployees = Employees;
            CurrentTabListBox = "All";
        }
    }
}
