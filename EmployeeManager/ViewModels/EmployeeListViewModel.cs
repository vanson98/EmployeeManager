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
        private List<EmployeeViewModel> rootData = new()
        {
            new EmployeeViewModel( new EmployeeModel()
            {
                Id = "G001",
                Name = "Nguyen Van Son",
                Email = "nguyenvanson@gmail.com",
                CreatedDate = new DateTime(2018,9,15),
                Dob = new DateTime(1998,9,15),
                Role = EmployeeRole.Developer,
                Status = EmployeeStatus.Online
            }),

            new EmployeeViewModel( new EmployeeModel()
            {
                Id = "G002",
                Name = "Le Thi Hoa",
                Email = "lethihoa@gmail.com",
                CreatedDate = new DateTime(2019,5,20),
                Dob = new DateTime(1995,3,10),
                Role = EmployeeRole.Tester,
                Status = EmployeeStatus.Offline
            }),

            new EmployeeViewModel( new EmployeeModel()
            {
                Id = "G003",
                Name = "Tran Van Binh",
                Email = "tranvanbinh@gmail.com",
                CreatedDate = new DateTime(2020,2,11),
                Dob = new DateTime(1992,7,25),
                Role = EmployeeRole.Developer,
                Status = EmployeeStatus.Offline
            }),

            new EmployeeViewModel( new EmployeeModel()
            {
                Id = "G004",
                Name = "Pham Minh Anh",
                Email = "phammanh@gmail.com",
                CreatedDate = new DateTime(2017,11,30),
                Dob = new DateTime(1990,12,5),
                Role = EmployeeRole.Developer,
                Status = EmployeeStatus.Online
            }),

            new EmployeeViewModel( new EmployeeModel()
            {
                Id = "G005",
                Name = "Hoang Dinh Nam",
                Email = "hoangnam@gmail.com",
                CreatedDate = new DateTime(2016,6,8),
                Dob = new DateTime(1985,1,20),
                Role = EmployeeRole.Developer,
                Status = EmployeeStatus.Update
            }),

            new EmployeeViewModel( new EmployeeModel()
            {
                Id = "G006",
                Name = "Doan Thi My",
                Email = "doanthimy@gmail.com",
                CreatedDate = new DateTime(2019,8,14),
                Dob = new DateTime(1997,11,11),
                Role = EmployeeRole.Designer,
                Status = EmployeeStatus.Online
            }),

            new EmployeeViewModel( new EmployeeModel()
            {
                Id = "G007",
                Name = "Nguyen Thanh Tu",
                Email = "nguyenthanhtu@gmail.com",
                CreatedDate = new DateTime(2021,4,21),
                Dob = new DateTime(1999,6,17),
                Role = EmployeeRole.Developer,
                Status = EmployeeStatus.Online
            }),

            new EmployeeViewModel( new EmployeeModel()
            {
                Id = "G008",
                Name = "Pham Van Linh",
                Email = "phamvanlinh@gmail.com",
                CreatedDate = new DateTime(2018,12,9),
                Dob = new DateTime(1994,2,3),
                Role = EmployeeRole.Tester,
                Status = EmployeeStatus.Online
            }),

            new EmployeeViewModel( new EmployeeModel()
            {
                Id = "G009",
                Name = "Vu Thi Lan",
                Email = "vuthilan@gmail.com",
                CreatedDate = new DateTime(2015,10,17),
                Dob = new DateTime(1988,4,28),
                Role = EmployeeRole.Developer,
                Status = EmployeeStatus.Offline
            }),

            new EmployeeViewModel( new EmployeeModel()
            {
                Id = "G010",
                Name = "Le Van Cuong",
                Email = "levancuong@gmail.com",
                CreatedDate = new DateTime(2017,7,19),
                Dob = new DateTime(1991,9,5),
                Role = EmployeeRole.Tester,
                Status = EmployeeStatus.Online
            }),

            new EmployeeViewModel( new EmployeeModel()
            {
                Id = "G011",
                Name = "Dang Minh Tri",
                Email = "dangminhtri@gmail.com",
                CreatedDate = new DateTime(2018,3,10),
                Dob = new DateTime(1993,8,15),
                Role = EmployeeRole.Developer,
                Status = EmployeeStatus.Online
            }),

            new EmployeeViewModel( new EmployeeModel()
            {
                Id = "G012",
                Name = "Trinh Thi Bao",
                Email = "trinhthibao@gmail.com",
                CreatedDate = new DateTime(2019,1,25),
                Dob = new DateTime(1996,5,30),
                Role = EmployeeRole.Developer,
                Status = EmployeeStatus.Online
            }),

            new EmployeeViewModel( new EmployeeModel()
            {
                Id = "G013",
                Name = "Nguyen Hoang Duy",
                Email = "nguyenhoangduy@gmail.com",
                CreatedDate = new DateTime(2017,5,5),
                Dob = new DateTime(1992,10,20),
                Role = EmployeeRole.Tester,
                Status = EmployeeStatus.Update
            }),

            new EmployeeViewModel( new EmployeeModel()
            {
                Id = "G014",
                Name = "Bui Thanh Long",
                Email = "buithanhlong@gmail.com",
                CreatedDate = new DateTime(2020,2,14),
                Dob = new DateTime(1995,7,7),
                Role =  EmployeeRole.Designer,
                Status = EmployeeStatus.Online
            }),

            new EmployeeViewModel( new EmployeeModel()
            {
                Id = "G015",
                Name = "Ha Thi Thu",
                Email = "hathithu@gmail.com",
                CreatedDate = new DateTime(2016,9,8),
                Dob = new DateTime(1990,12,1),
                Role =  EmployeeRole.Designer,
                Status = EmployeeStatus.Online
            }),

            new EmployeeViewModel(new EmployeeModel()
            {
                Id = "G0016",
                Name = "Le Minh Ngoc",
                Email = "lmn@gmail.com",
                CreatedDate = new DateTime(2018,9,15),
                Dob = new DateTime(1998,9,15),
                Role =  EmployeeRole.Designer,
                Status = EmployeeStatus.Offline
            }),
        };

        [ObservableProperty]
        public List<string> _roleItems = Enum.GetNames(typeof(EmployeeRole)).ToList();

        [ObservableProperty]
        public List<string> _employeeStatusItems = Enum.GetNames(typeof(EmployeeStatus)).ToList();

        [ObservableProperty]
        private List<EmployeeViewModel> _employeeGridData;

        [ObservableProperty]
        private string _selectedRole;

        [ObservableProperty]
        private string _selectedStatus;

        [ObservableProperty]
        private string? _textSearch;

        partial void OnSelectedRoleChanged(string value)
        {
            SearchEmployee();
        }

        partial void OnSelectedStatusChanged(string value)
        {
            SearchEmployee();
        }

        public EmployeeListViewModel()
        {
            EmployeeGridData = rootData;
        }

        [RelayCommand]
        private void SearchEmployee()
        {
            EmployeeGridData = rootData
                .Where(e => string.IsNullOrEmpty(SelectedRole) || e.Employee.Role.ToString() == SelectedRole)
                .Where(e => string.IsNullOrEmpty(SelectedStatus) || e.Employee.Status.ToString() == SelectedStatus)
                .Where(e => string.IsNullOrEmpty(TextSearch) || e.Employee.Email.Contains(TextSearch) || e.Employee.Name.Contains(TextSearch))
                .ToList();
        }

    }
}
