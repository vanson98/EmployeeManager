using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EmployeeManager.Models;
using EmployeeManager.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.ViewModels
{
    public partial class EmployeeViewModel : ObservableObject
    {
        [ObservableProperty]
        private EmployeeModel _employee;

        public EmployeeViewModel(EmployeeModel employee)
        {
            Employee = employee;
        }

        public string Id
        {
            get => Employee.Id;
            set
            {
                Employee.Id = value;
            }
        }

        public string Name
        {
            get => Employee.Name;
            set
            {
                Employee.Name = value;
            }
        }

        public string Email
        {
            get => Employee.Email;
            set
            {
                Employee.Email = value;
            }
        }

        public DateTime CreatedDate
        {
            get => Employee.CreatedDate;
            set
            {
                Employee.CreatedDate = value;
            }
        }

        public EmployeeStatus Status
        {
            get => Employee.Status;
            set
            {
                Employee.Status = value;
                OnPropertyChanged(nameof(Status));
            }
        }


        [RelayCommand]
        private void ToggleEmployeeStatus()
        {
            if (Status is EmployeeStatus.Online)
            {
                Status = EmployeeStatus.Offline;
            }
            else
            {
                Status = EmployeeStatus.Online;
            }
        }
    }
}
