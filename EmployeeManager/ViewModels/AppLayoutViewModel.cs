using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
        private UserControl _viewComponent = new EmployeeList();
        
        [RelayCommand]        
        public void MoveToInfoView()
        {
            ViewComponent = new EmployeeInfo();
        }
    }
}
