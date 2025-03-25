using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EmployeeManager.Models;
using EmployeeManager.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EmployeeManager.ViewModels
{
    public partial class EmployeeUpdateFormViewModel : ObservableObject
    {
        [ObservableProperty]
        private EmployeeModel _employee;
    }
}
