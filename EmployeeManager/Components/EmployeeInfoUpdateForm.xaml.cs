using EmployeeManager.Models;
using EmployeeManager.ViewModels;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for EmployeeInfoUpdateForm.xaml
    /// </summary>
    public partial class EmployeeInfoUpdateForm : UserControl
    {
        public EmployeeUpdateFormViewModel ViewModel { get; }
        public EmployeeModel EmployeeData
        {
            get { return (EmployeeModel)GetValue(EmployeeDataProperty); }
            set { SetValue(EmployeeDataProperty, value); }
        }

        // Using a DependencyProperty as the backing store for EmployeeData.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmployeeDataProperty =
            DependencyProperty.Register("EmployeeData", typeof(EmployeeModel), typeof(EmployeeInfoUpdateForm), new PropertyMetadata(null, OnEmployeeDataChange));

        private static void OnEmployeeDataChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if(d is EmployeeInfoUpdateForm control && e.NewValue is EmployeeModel newEmployee)
            {
                control.ViewModel.Employee = new EmployeeModel() { 
                    Id = newEmployee.Id,
                    Name = newEmployee.Name,
                    Email = newEmployee.Email,
                    Dob = newEmployee.Dob,
                    PhoneNumber = newEmployee.PhoneNumber,
                    Gender = newEmployee.Gender
                };
            }
        }

        public EmployeeInfoUpdateForm()
        {
            InitializeComponent();
            ViewModel = new EmployeeUpdateFormViewModel();
            DataContext = ViewModel;
        }


    }
}
