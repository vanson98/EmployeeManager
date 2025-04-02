using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using EmployeeManager.Models;
using EmployeeManager.Models.Enums;
using EmployeeManager.ViewModels.MessageTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.ViewModels
{
    public partial class AddEmployeeViewModel : ObservableObject
    {
        [ObservableProperty]
        private EmployeeModel _newEmployee = new EmployeeModel();

        public AddEmployeeViewModel()
        {
            NewEmployee.Dob = DateTime.Now;
        }

        [RelayCommand]
        private void SubmitForm()
        {
            var messenger = WeakReferenceMessenger.Default;
            NewEmployee.CreatedDate = DateTime.Now;
            NewEmployee.OnTime = 15;
            NewEmployee.OnLeave = 3;
            NewEmployee.Late = 4;
            NewEmployee.ProjectAttendances = new List<ProjectAttendance>
            {
                new ProjectAttendance{ Year = 2025, Month = 3, Week = 1, WorkingHourPercent = 25, Project= EmployeeProject.BeeProxy },
                new ProjectAttendance{ Year = 2025, Month = 3, Week = 1, WorkingHourPercent = 50, Project = EmployeeProject.NineProxy },
                new ProjectAttendance{ Year = 2025, Month = 3, Week = 1, WorkingHourPercent = 20, Project = EmployeeProject.SolarVPN },

                new ProjectAttendance{ Year = 2025, Month = 3, Week = 2, WorkingHourPercent = 18, Project= EmployeeProject.BeeProxy },
                new ProjectAttendance{ Year = 2025, Month = 3, Week = 2, WorkingHourPercent = 30, Project = EmployeeProject.NineProxy },
                new ProjectAttendance{ Year = 2025, Month = 3, Week = 2, WorkingHourPercent = 20, Project = EmployeeProject.SolarVPN },

                new ProjectAttendance{ Year = 2025, Month = 3, Week = 3, WorkingHourPercent = 22, Project= EmployeeProject.BeeProxy },
                new ProjectAttendance{ Year = 2025, Month = 3, Week = 3, WorkingHourPercent = 45, Project = EmployeeProject.NineProxy },
                new ProjectAttendance{ Year = 2025, Month = 3, Week = 3, WorkingHourPercent = 15, Project = EmployeeProject.SolarVPN },

                new ProjectAttendance{ Year = 2025, Month = 3, Week = 4, WorkingHourPercent = 30, Project= EmployeeProject.BeeProxy },
                new ProjectAttendance{ Year = 2025, Month = 3, Week = 4, WorkingHourPercent = 50, Project = EmployeeProject.NineProxy },
                new ProjectAttendance{ Year = 2025, Month = 3, Week = 4, WorkingHourPercent = 15, Project = EmployeeProject.SolarVPN },
            };
            messenger.Send(new AddNewEmployeeMessage(NewEmployee));
        }
    }
}
