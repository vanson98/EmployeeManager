using EmployeeManager.Components;
using EmployeeManager.Models;
using EmployeeManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EmployeeManager.Views
{
    /// <summary>
    /// Interaction logic for EmployeeList.xaml
    /// </summary>
    public partial class EmployeeList : UserControl
    {
        public EmployeeListViewModel ViewModel { get; }
        public EmployeeList()
        {
            InitializeComponent();
            ViewModel = new EmployeeListViewModel();
            DataContext = ViewModel;
        }

        public ObservableCollection<EmployeeModel> Employees
        {
            get { return (ObservableCollection<EmployeeModel>)GetValue(EmployeesProperty); }
            set { SetValue(EmployeesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for EmployeesData.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmployeesProperty =
            DependencyProperty.Register("Employees", typeof(ObservableCollection<EmployeeModel>), typeof(EmployeeList), new PropertyMetadata(null, EmployeesChanged));

        private static void EmployeesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if(d is EmployeeList control && e.NewValue is ObservableCollection<EmployeeModel> employeeModels)
            {
                control.ViewModel.EmployeeGridData = new ObservableCollection<EmployeeViewModel>();
                foreach (var item in employeeModels)
                {
                    control.ViewModel.EmployeeGridData.Add(new EmployeeViewModel(item));
                }
            }
        }
    }
}
