using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EmployeeManager.Models;
using EmployeeManager.Models.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeManager.ViewModels
{
    public partial class EmployeeListViewModel : ObservableObject
    {
        [ObservableProperty]
        public List<string> _roleItems = Enum.GetNames(typeof(EmployeeRole)).ToList();

        [ObservableProperty]
        public List<string> _employeeStatusItems = Enum.GetNames(typeof(EmployeeStatus)).ToList();

        [ObservableProperty]
        private ObservableCollection<EmployeeViewModel> _employeeGridData;

        public EmployeeListViewModel()
        {

        }
    }
}
