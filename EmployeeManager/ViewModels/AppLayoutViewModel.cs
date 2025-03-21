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
        private object _currentViewModel;
        
        public AppLayoutViewModel()
        {
            _currentViewModel = new EmployeeListViewModel();
        }
        [RelayCommand]        
        public void MoveToInfoView()
        {
            CurrentViewModel = new EmployeeInfoViewModel();
        }
    }
}
