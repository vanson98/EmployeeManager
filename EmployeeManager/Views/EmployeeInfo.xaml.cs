using EmployeeManager.Models;
using EmployeeManager.Models.Enums;
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
    /// Interaction logic for EmployeeInfo.xaml
    /// </summary>
    public partial class EmployeeInfo : UserControl
    {
        public EmployeeInfoViewModel ViewModel;

        public EmployeeModel EmployeeDetailData
        {
            get { return (EmployeeModel)GetValue(EmployeeDetailDataProperty); }
            set { SetValue(EmployeeDetailDataProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmployeeDetailDataProperty =
            DependencyProperty.Register("EmployeeDetailData", typeof(EmployeeModel), typeof(EmployeeInfo), new PropertyMetadata(null, OnDetailEmployeeDataChanged));

        private static void OnDetailEmployeeDataChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is EmployeeInfo control && e.NewValue is EmployeeModel value)
            {
                control.ViewModel.CurrentEmployeeDetailInfo = value;
            }
        }

        public ObservableCollection<EmployeeModel> Employees
        {
            get { return (ObservableCollection<EmployeeModel>)GetValue(EmployeesProperty); }
            set { SetValue(EmployeesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmployeesProperty =
            DependencyProperty.Register("Employees", typeof(ObservableCollection<EmployeeModel>), typeof(EmployeeInfo), new PropertyMetadata(null, OnEmployeesPropertyChanged));

        private static void OnEmployeesPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is EmployeeInfo control && e.NewValue is ObservableCollection<EmployeeModel> employees)
            {
                control.ViewModel.Employees = employees;
                control.ViewModel.FilterEmployees = employees;
                control.ViewModel.CurrentTabListBox = EmployeeRoleTab.All;
            }
        }
        public EmployeeInfo()
        {
            ViewModel = new EmployeeInfoViewModel();
            DataContext = ViewModel;
            InitializeComponent();
           
        }

       
    }
}
