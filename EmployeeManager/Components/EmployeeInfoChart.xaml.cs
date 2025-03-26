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

namespace EmployeeManager.Components
{
    /// <summary>
    /// Interaction logic for EmployeeInfoChart.xaml
    /// </summary>
    public partial class EmployeeInfoChart : UserControl
    {
        public EmployeeChartViewModel ViewModel;

        public ObservableCollection<EmployeeModel> RelatedEmployees
        {
            get { return (ObservableCollection<EmployeeModel>)GetValue(RelatedEmployeesProperty); }
            set { SetValue(RelatedEmployeesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RelatedEmployeesProperty =
            DependencyProperty.Register("RelatedEmployees", typeof(ObservableCollection<EmployeeModel>), typeof(EmployeeInfoChart), new PropertyMetadata(null));


        public EmployeeInfoChart()
        {
            InitializeComponent();
            DataContext = ViewModel;
        }
    }
}
