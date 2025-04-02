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
        private EmployeeModel _currentEmployeeDetailInfo;
        
        [ObservableProperty]
        private ObservableCollection<EmployeeModel> _employees;
        
        [ObservableProperty]
        private ObservableCollection<EmployeeModel> _filterEmployees;

        [ObservableProperty]
        private object _currentTabViewModel;

        [ObservableProperty]
        private EmployeeRoleTab _currentTabListBox = EmployeeRoleTab.All; 

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
        private void FilterEmployeeTabList(EmployeeRoleTab tab)
        {
            if(tab == EmployeeRoleTab.Team)
            {
                FilterEmployees = [..Employees.Where(e=>e.Role == EmployeeRole.Developer || e.Role == EmployeeRole.Tester)];
                CurrentTabListBox = EmployeeRoleTab.Team;
                return;
            }
            else if(tab == EmployeeRoleTab.Leader)
            {
                FilterEmployees = [.. Employees.Where(e => e.Role == EmployeeRole.Designer)];
                CurrentTabListBox = EmployeeRoleTab.Leader;
                return;
            }
            FilterEmployees = Employees;
            CurrentTabListBox = EmployeeRoleTab.All;
        }
    }
}
