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



        public int TotalRecord
        {
            get { return (int)GetValue(TotalRecordProperty); }
            set { SetValue(TotalRecordProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TotalRecord.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TotalRecordProperty =
            DependencyProperty.Register("TotalRecord", typeof(int), typeof(EmployeeList), new PropertyMetadata(0, OnTotalRecordChanged));

        private static void OnTotalRecordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is EmployeeList control && e.NewValue is int total)
            {
                control.ViewModel.TotalRecord = total;
                control.ViewModel.TotalPage = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(total) / control.ViewModel.PageSize));
                control.ViewModel.CurrentPage = 1;
            }
        }

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
