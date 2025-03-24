using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EmployeeManager.Models;
using EmployeeManager.Models.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeManager.ViewModels
{
    public partial class EmployeeListViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<EmployeeViewModel> _employees = new ObservableCollection<EmployeeViewModel>()
        {
            new EmployeeViewModel( new EmployeeModel()
            {
                Id = "G001",
                Name = "Nguyen Van Son",
                Email = "nguyenvanson98123@gmail.com",
                CreatedDate = new DateTime(2018,9,15),
                Dob = new DateTime(1998,9,15),
                Role = "Manager",
                Status = EmployeeStatus.Active
            }),
            new EmployeeViewModel(new EmployeeModel()
            {
                Id = "G002",
                Name = "Le Minh Ngoc",
                Email = "lmn@gmail.com",
                CreatedDate = new DateTime(2018,9,15),
                Dob = new DateTime(1998,9,15),
                Role = "Developer",
                Status = EmployeeStatus.Unactive
            })
        };

        public EmployeeListViewModel()
        {
        }

    }
}
