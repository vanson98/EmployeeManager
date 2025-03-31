using CommunityToolkit.Mvvm.ComponentModel;
using EmployeeManager.Models;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.ViewModels
{
    public partial class EmployeeChartViewModel : ObservableObject
    {
        [ObservableProperty]
        private EmployeeModel _employee;

       
    }
}
