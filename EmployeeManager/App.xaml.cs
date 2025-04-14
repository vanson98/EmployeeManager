using System.Configuration;
using System.Data;
using System.Windows;
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;
using Windows.System;

namespace EmployeeManager;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
        {
            return typeof(DispatcherQueue).Assembly;
        };
       
    }
}

