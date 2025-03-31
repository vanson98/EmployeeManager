using CommunityToolkit.Mvvm.Messaging;
using EmployeeManager.ViewModels;
using EmployeeManager.ViewModels.MessageTypes;
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
using System.Windows.Shapes;

namespace EmployeeManager.AppWindows
{
    /// <summary>
    /// Interaction logic for AddEmployeeWindow.xaml
    /// </summary>
    public partial class AddEmployeeWindow : Window
    {
        public AddEmployeeWindow()
        {
            InitializeComponent();
            DataContext = new AddEmployeeViewModel();
            WeakReferenceMessenger.Default.Register<SubmitAddEmployeeFormMessage>(this, (r, message) =>
            {
                if (message.Value == "AddEmployeeSuccess")
                {
                    this.Close();
                    return;
                }
            });
        }

        private void CloseWindowButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddingEmployeeWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}
