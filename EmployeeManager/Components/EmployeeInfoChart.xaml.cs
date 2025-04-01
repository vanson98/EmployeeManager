using EmployeeManager.Models;
using EmployeeManager.ViewModels;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections;

namespace EmployeeManager.Components
{
    /// <summary>
    /// Interaction logic for EmployeeInfoChart.xaml
    /// </summary>
    public partial class EmployeeInfoChart : UserControl
    {
        public EmployeeChartViewModel ViewModel;

        public IEnumerable<EmployeeModel> RelatedEmployees
        {
            get { return (IEnumerable<EmployeeModel>)GetValue(RelatedEmployeesProperty); }
            set { SetValue(RelatedEmployeesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RelatedEmployeesProperty =
            DependencyProperty.Register("RelatedEmployees", typeof(IEnumerable<EmployeeModel>), typeof(EmployeeInfoChart), new PropertyMetadata(null, OnRelatedEmployeesChanged));

        private static void OnRelatedEmployeesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is EmployeeInfoChart control && e.NewValue is IEnumerable<EmployeeModel> relatedEmployees) 
            {
                control.ViewModel.RelatedEmployees = new ObservableCollection<EmployeeModel>(relatedEmployees);    
            }
        }   

        public EmployeeModel EmployeeInfo
        {
            get { return (EmployeeModel)GetValue(EmployeeInfoProperty); }
            set { SetValue(EmployeeInfoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for EmployeeInfo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmployeeInfoProperty =
            DependencyProperty.Register("EmployeeInfo", typeof(EmployeeModel), typeof(EmployeeInfoChart), new PropertyMetadata(null, OnEmployeeInfoChange));

     

        private static void OnEmployeeInfoChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is EmployeeInfoChart control && e.NewValue is EmployeeModel data)
            {
                control.ViewModel.Employee = data;
            }
        }

        public EmployeeInfoChart()
        {
            ViewModel = new EmployeeChartViewModel();
            DataContext = ViewModel;
            InitializeComponent();
        }
    }
}
