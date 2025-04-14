using EmployeeManager.ViewModels;
using Microsoft.UI;
using Microsoft.UI.Windowing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Windows.Graphics;

namespace EmployeeManager.AppWindows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private bool IsMaximized = true;
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new AppLayoutViewModel();
        //this.WindowState = WindowState.Maximized;
    }

    private void BorderWindow_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if(e.ChangedButton == MouseButton.Left)
        {
            this.DragMove();
        }
    }

    private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        if(e.ClickCount == 2)
        {
            if (IsMaximized)
            {
                this.WindowState = WindowState.Normal;
                this.Width = 1080;
                this.Height = 720;
                IsMaximized = false;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
                IsMaximized = true;
            }
        }
    }

    private void CloseWindowButton_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }

    private void ResizeWindowButton_Click(object sender, RoutedEventArgs e)
    {
        this.WindowState = WindowState.Normal;
    }

    private void HideWindowButton_Click(object sender, RoutedEventArgs e)
    {
        this.Hide();
        this.ShowInTaskbar = true;
    }

}