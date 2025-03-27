using CommunityToolkit.Mvvm.ComponentModel;
using EmployeeManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.ViewModels
{
    public partial class AddEmployeeViewModel : ObservableObject
    {
        [ObservableProperty]
        private EmployeeModel _employee;

    }
}
