using CommunityToolkit.Mvvm.ComponentModel;
using EmployeeManager.Models;
using EmployeeManager.Models.Enums;
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

        [ObservableProperty]
        private ISeries[] _projectAttendanceChartSeries;

        [ObservableProperty]
        public Axis[] _xAxes = new Axis[]
        {
            new Axis
            {
                // Use the labels property to define named labels.
                Labels = new string[] { "Tuần 1", "Tuần 2", "Tuần 3", "Tuần 4" },
                LabelsPaint = new SolidColorPaint(SKColors.White),
                TextSize = 16,
            }
        };

        [ObservableProperty]
        public Axis[] _yAxes = new Axis[]
        {
            new Axis
            {
                Labeler = (value) => $"{value}%",
                LabelsPaint = new SolidColorPaint(SKColors.White),
                TextSize = 16,
            }
        };

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
            
            ProjectAttendanceChartSeries = new ISeries[]
            {
                new ColumnSeries<float>
                {
                    Values = Employee.ProjectAttendances.Where(pa => pa.Project == EmployeeProject.NineProxy).Select(pa=>pa.WorkingHourPercent).ToArray(),
                    Name = EmployeeProject.NineProxy.ToString(),
                    Fill = new SolidColorPaint(SKColor.Parse("#1279FF")),
                    MaxBarWidth = 25, 
                    Padding = 8
                },
                new ColumnSeries<float>
                {
                    Values = Employee.ProjectAttendances.Where(pa => pa.Project == EmployeeProject.BeeProxy).Select(pa=>pa.WorkingHourPercent).ToArray(),
                    Name = EmployeeProject.BeeProxy.ToString(),
                    Fill = new SolidColorPaint(SKColor.Parse("#FFD93C")),
                    MaxBarWidth = 25,
                     Padding = 8
                },
                new ColumnSeries<float>
                {
                    Values = Employee.ProjectAttendances.Where(pa => pa.Project == EmployeeProject.SolarVPN).Select(pa=>pa.WorkingHourPercent).ToArray(),
                    Name = EmployeeProject.SolarVPN.ToString(),
                    Fill = new SolidColorPaint(SKColor.Parse("#FF4535")),
                    MaxBarWidth = 25,
                     Padding = 8
                }
            };
        }

        public EmployeeChartViewModel()
        {
        }
    }
}
