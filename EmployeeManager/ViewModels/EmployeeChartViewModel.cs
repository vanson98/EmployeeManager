using CommunityToolkit.Mvvm.ComponentModel;
using EmployeeManager.Models;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EmployeeManager.ViewModels
{
    public partial class EmployeeChartViewModel : ObservableObject
    {
        [ObservableProperty]
        private EmployeeModel _employee;

        [ObservableProperty]
        private ISeries[] _pieChartSeries;

        partial void OnEmployeeChanged(EmployeeModel value)
        {
            PieChartSeries = new ISeries[]
            {
               new PieSeries<int>{ 
                   Values = new int[]{ value.OnTime },
                   Fill = new SolidColorPaint(SKColor.Parse("#3FFF30")),
                   InnerRadius= 70
               },
               new PieSeries<int>{ 
                   Values = new int[]{ value.Late },
                   Fill = new SolidColorPaint(SKColor.Parse("#FFBD2F")),
                   InnerRadius= 70
               },
               new PieSeries<int>{ 
                   Values = new int[]{ value.OnLeave },
                   Fill = new SolidColorPaint(SKColor.Parse("#FF1400")),
                   InnerRadius= 70
               }
            };
        }

        public EmployeeChartViewModel()
        {
            PieChartSeries = new ISeries[]
            {
                new PieSeries<double> { Values = new double[] { 2 } },
                new PieSeries<double> { Values = new double[] { 4 } },
                new PieSeries<double> { Values = new double[] { 1 } },
                new PieSeries<double> { Values = new double[] { 4 } },
                new PieSeries<double> { Values = new double[] { 3 } }
            };
        }
    }
}
