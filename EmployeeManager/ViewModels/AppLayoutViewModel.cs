using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using EmployeeManager.Models;
using EmployeeManager.Models.Enums;
using EmployeeManager.ViewModels.MessageTypes;
using EmployeeManager.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EmployeeManager.ViewModels
{
    public partial class AppLayoutViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<EmployeeModel> _rootData;

        [ObservableProperty]
        private ObservableCollection<EmployeeModel> _searchedEmployees;

        [ObservableProperty]
        private object _currentViewModel;

        [ObservableProperty]
        private EmployeeModel? _currentEmployeeDetail;

        public AppLayoutViewModel()
        {
            WeakReferenceMessenger.Default.Register<AddNewEmployeeMessage>(this, (r, messsage) =>
            {
                SubmitAddEmployeeForm(messsage.Value);
            });
            RootData = new()
            {
                new EmployeeModel()
                {
                    Id = "EMP001",
                    Name = "Nguyen Van Son",
                    Email = "nguyenvanson@gmail.com",
                    PhoneNumber = "0987654321",
                    Gender = EmployeeGender.Male,
                    CreatedDate = new DateTime(2018, 9, 15),
                    Dob = new DateTime(1998, 9, 15),
                    Role = EmployeeRole.Developer,
                    Status = EmployeeStatus.Online,
                    OnTime = 20,
                    Late = 5,
                    OnLeave = 2,
                    AvatarPath = "/Images/avatars/av4.png"
                },

                new EmployeeModel()
                {
                    Id = "EMP002",
                    Name = "Le Thi Hoa",
                    Email = "lethihoa@gmail.com",
                    PhoneNumber = "0978654321",
                    Gender = EmployeeGender.Female,
                    CreatedDate = new DateTime(2019, 5, 20),
                    Dob = new DateTime(1995, 3, 10),
                    Role = EmployeeRole.Tester,
                    Status = EmployeeStatus.Offline,
                    OnTime = 18,
                    Late = 3,
                    OnLeave = 1,
                    AvatarPath = "/Images/avatars/av3.png"
                },

                new EmployeeModel()
                {
                    Id = "EMP003",
                    Name = "Tran Van Binh",
                    Email = "tranvanbinh@gmail.com",
                    PhoneNumber = "0968541237",
                    Gender = EmployeeGender.Male,
                    CreatedDate = new DateTime(2020, 2, 11),
                    Dob = new DateTime(1992, 7, 25),
                    Role = EmployeeRole.Developer,
                    Status = EmployeeStatus.Offline,
                    OnTime = 22,
                    Late = 1,
                    OnLeave = 0,
                    AvatarPath = "/Images/avatars/av2.png"
                },

                new EmployeeModel()
                {
                    Id = "EMP004",
                    Name = "Pham Minh Anh",
                    Email = "phammanh@gmail.com",
                    PhoneNumber = "0954732156",
                    Gender = EmployeeGender.Male,
                    CreatedDate = new DateTime(2017, 11, 30),
                    Dob = new DateTime(1990, 12, 5),
                    Role = EmployeeRole.Developer,
                    Status = EmployeeStatus.Online,
                    OnTime = 19,
                    Late = 2,
                    OnLeave = 3,
                    AvatarPath = "/Images/avatars/av1.png"
                },

                new EmployeeModel()
                {
                    Id = "EMP005",
                    Name = "Hoang Dinh Nam",
                    Email = "hoangnam@gmail.com",
                    PhoneNumber = "0985123697",
                    Gender = EmployeeGender.Male,
                    CreatedDate = new DateTime(2016, 6, 8),
                    Dob = new DateTime(1985, 1, 20),
                    Role = EmployeeRole.Developer,
                    Status = EmployeeStatus.Update,
                    OnTime = 25,
                    Late = 6,
                    OnLeave = 1,
                    AvatarPath = "/Images/avatars/av8.png"
                },

                new EmployeeModel()
                {
                    Id = "EMP006",
                    Name = "Doan Thi My",
                    Email = "doanthimy@gmail.com",
                    PhoneNumber = "0912365478",
                    Gender = EmployeeGender.Female,
                    CreatedDate = new DateTime(2019, 8, 14),
                    Dob = new DateTime(1997, 11, 11),
                    Role = EmployeeRole.Designer,
                    Status = EmployeeStatus.Online,
                    OnTime = 15,
                    Late = 2,
                    OnLeave = 4,
                    AvatarPath = "/Images/avatars/av7.png"
                },

                new EmployeeModel()
                {
                    Id = "EMP007",
                    Name = "Nguyen Thanh Tu",
                    Email = "nguyenthanhtu@gmail.com",
                    PhoneNumber = "0978456231",
                    Gender = EmployeeGender.Male,
                    CreatedDate = new DateTime(2021, 4, 21),
                    Dob = new DateTime(1999, 6, 17),
                    Role = EmployeeRole.Developer,
                    Status = EmployeeStatus.Online,
                    OnTime = 17,
                    Late = 1,
                    OnLeave = 2,
                    AvatarPath = "/Images/avatars/av6.png"
                },

                new EmployeeModel()
                {
                    Id = "EMP008",
                    Name = "Pham Van Linh",
                    Email = "phamvanlinh@gmail.com",
                    PhoneNumber = "0923654789",
                    Gender = EmployeeGender.Male,
                    CreatedDate = new DateTime(2018, 12, 9),
                    Dob = new DateTime(1994, 2, 3),
                    Role = EmployeeRole.Tester,
                    Status = EmployeeStatus.Online,
                    OnTime = 20,
                    Late = 4,
                    OnLeave = 1,
                    AvatarPath = "/Images/avatars/av5.png"
                },

                new EmployeeModel()
                {
                    Id = "EMP009",
                    Name = "Vu Thi Lan",
                    Email = "vuthilan@gmail.com",
                    PhoneNumber = "0965123748",
                    Gender = EmployeeGender.Female,
                    CreatedDate = new DateTime(2015, 10, 17),
                    Dob = new DateTime(1988, 4, 28),
                    Role = EmployeeRole.Developer,
                    Status = EmployeeStatus.Offline,
                    OnTime = 23,
                    Late = 2,
                    OnLeave = 3,
                    AvatarPath = "/Images/avatars/av4.png"
                },

                new EmployeeModel()
                {
                    Id = "EMP010",
                    Name = "Le Van Cuong",
                    Email = "levancuong@gmail.com",
                    PhoneNumber = "0978651234",
                    Gender = EmployeeGender.Male,
                    CreatedDate = new DateTime(2017, 7, 19),
                    Dob = new DateTime(1991, 9, 5),
                    Role = EmployeeRole.Tester,
                    Status = EmployeeStatus.Online,
                    OnTime = 18,
                    Late = 1,
                    OnLeave = 2,
                    AvatarPath = "/Images/avatars/av3.png"
                },
                new EmployeeModel()
                {
                    Id = "EMP011",
                    Name = "Pham Quang Huy",
                    Email = "phamquanghuy@gmail.com",
                    PhoneNumber = "0945123456",
                    Gender = EmployeeGender.Male,
                    CreatedDate = new DateTime(2022, 1, 15),
                    Dob = new DateTime(1997, 10, 10),
                    Role = EmployeeRole.Developer,
                    Status = EmployeeStatus.Online,
                    OnTime = 19,
                    Late = 2,
                    OnLeave = 1,
                    AvatarPath = "/Images/avatars/av2.png"
                },

                new EmployeeModel()
                {
                    Id = "EMP012",
                    Name = "Tran Minh Khoa",
                    Email = "tranminhkhoa@gmail.com",
                    PhoneNumber = "0912345678",
                    Gender = EmployeeGender.Male,
                    CreatedDate = new DateTime(2021, 6, 20),
                    Dob = new DateTime(1996, 5, 18),
                    Role = EmployeeRole.Tester,
                    Status = EmployeeStatus.Online,
                    OnTime = 22,
                    Late = 1,
                    OnLeave = 0,
                    AvatarPath = "/Images/avatars/av1.png"
                },

                new EmployeeModel()
                {
                    Id = "EMP013",
                    Name = "Vu Thi Mai",
                    Email = "vuthimai@gmail.com",
                    PhoneNumber = "0978543216",
                    Gender = EmployeeGender.Female,
                    CreatedDate = new DateTime(2018, 3, 11),
                    Dob = new DateTime(1993, 12, 25),
                    Role = EmployeeRole.Designer,
                    Status = EmployeeStatus.Online,
                    OnTime = 18,
                    Late = 4,
                    OnLeave = 2,
                    AvatarPath = "/Images/avatars/av8.png"
                },

                new EmployeeModel()
                {
                    Id = "EMP014",
                    Name = "Le Dinh Bao",
                    Email = "ledinhbao@gmail.com",
                    PhoneNumber = "0956784321",
                    Gender = EmployeeGender.Male,
                    CreatedDate = new DateTime(2020, 7, 14),
                    Dob = new DateTime(1995, 2, 7),
                    Role = EmployeeRole.Developer,
                    Status = EmployeeStatus.Offline,
                    OnTime = 20,
                    Late = 3,
                    OnLeave = 1,
                    AvatarPath = "/Images/avatars/av7.png"
                },

                new EmployeeModel()
                {
                    Id = "EMP015",
                    Name = "Doan Thi Thanh",
                    Email = "doanthithanh@gmail.com",
                    PhoneNumber = "0965214789",
                    Gender = EmployeeGender.Female,
                    CreatedDate = new DateTime(2019, 9, 30),
                    Dob = new DateTime(1992, 6, 20),
                    Role = EmployeeRole.Designer,
                    Status = EmployeeStatus.Online,
                    OnTime = 17,
                    Late = 2,
                    OnLeave = 3,
                    AvatarPath = "/Images/avatars/av6.png"
                },

                new EmployeeModel()
                {
                    Id = "EMP016",
                    Name = "Nguyen Tuan Anh",
                    Email = "nguyentuananh@gmail.com",
                    PhoneNumber = "0987541236",
                    Gender = EmployeeGender.Male,
                    CreatedDate = new DateTime(2017, 4, 5),
                    Dob = new DateTime(1989, 8, 12),
                    Role = EmployeeRole.Tester,
                    Status = EmployeeStatus.Offline,
                    OnTime = 23,
                    Late = 1,
                    OnLeave = 0,
                    AvatarPath = "/Images/avatars/av5.png"
                },

                new EmployeeModel()
                {
                    Id = "EMP017",
                    Name = "Hoang Thi Nhung",
                    Email = "hoangthinung@gmail.com",
                    PhoneNumber = "0912365987",
                    Gender = EmployeeGender.Female,
                    CreatedDate = new DateTime(2018, 11, 8),
                    Dob = new DateTime(1991, 1, 30),
                    Role = EmployeeRole.Developer,
                    Status = EmployeeStatus.Online,
                    OnTime = 19,
                    Late = 2,
                    OnLeave = 3,
                    AvatarPath = "/Images/avatars/av4.png"
                },

                new EmployeeModel()
                {
                    Id = "EMP018",
                    Name = "Bui Van Long",
                    Email = "buivanlong@gmail.com",
                    PhoneNumber = "0978654123",
                    Gender = EmployeeGender.Male,
                    CreatedDate = new DateTime(2016, 5, 12),
                    Dob = new DateTime(1987, 4, 22),
                    Role = EmployeeRole.Developer,
                    Status = EmployeeStatus.Offline,
                    OnTime = 25,
                    Late = 4,
                    OnLeave = 1,
                    AvatarPath = "/Images/avatars/av3.png"
                },

                new EmployeeModel()
                {
                    Id = "EMP019",
                    Name = "Pham Thanh Ha",
                    Email = "phamthanhha@gmail.com",
                    PhoneNumber = "0968745231",
                    Gender = EmployeeGender.Female,
                    CreatedDate = new DateTime(2020, 2, 25),
                    Dob = new DateTime(1996, 7, 17),
                    Role = EmployeeRole.Tester,
                    Status = EmployeeStatus.Online,
                    OnTime = 21,
                    Late = 2,
                    OnLeave = 1,
                    AvatarPath = "/Images/avatars/av2.png"
                },

                new EmployeeModel()
                {
                    Id = "EMP020",
                    Name = "Dang Minh Quan",
                    Email = "dangminhquan@gmail.com",
                    PhoneNumber = "0956324789",
                    Gender = EmployeeGender.Male,
                    CreatedDate = new DateTime(2022, 8, 10),
                    Dob = new DateTime(1998, 3, 5),
                    Role = EmployeeRole.Developer,
                    Status = EmployeeStatus.Online,
                    OnTime = 20,
                    Late = 3,
                    OnLeave = 2,
                    AvatarPath = "/Images/avatars/av1.png"
                }
            };
            SearchedEmployees = RootData;
            _currentViewModel = new EmployeeListViewModel();
            _currentEmployeeDetail = null;
        }

        [RelayCommand]
        private void MoveToInfoView(EmployeeModel employee)
        {
            CurrentViewModel = new EmployeeInfoViewModel();
            CurrentEmployeeDetail = employee;
        }

        [RelayCommand]
        private void MoveToListEmployeeView()
        {
            if (CurrentEmployeeDetail == null)
            {
                return;
            }
            CurrentViewModel = new EmployeeListViewModel();
            CurrentEmployeeDetail = null;
        }

        [ObservableProperty]
        private string _selectedRole;

        [ObservableProperty]
        private string _selectedStatus;

        [ObservableProperty]
        private string? _textSearch;

        [ObservableProperty]
        private int _totalSearchRecord;

        partial void OnSelectedRoleChanged(string value)
        {
            SearchEmployee();
        }

        partial void OnSelectedStatusChanged(string value)
        {
            SearchEmployee();
        }
        partial void OnTextSearchChanged(string? value)
        {
            SearchEmployee();
        }

        [RelayCommand]
        private void SearchEmployee()
        {
            SearchedEmployees = null;
            SearchedEmployees = [.. RootData
                .Where(e => string.IsNullOrEmpty(SelectedRole) || e.Role.ToString() == SelectedRole)
                .Where(e => string.IsNullOrEmpty(SelectedStatus) || e.Status.ToString() == SelectedStatus)
                .Where(e => string.IsNullOrEmpty(TextSearch) || e.Email.Contains(TextSearch) || e.Name.Contains(TextSearch))];
            TotalSearchRecord = SearchedEmployees.Count();

        }

        [RelayCommand]
        public void SubmitUpdateForm(EmployeeModel updateEmployee)
        {
            var employee = RootData.FirstOrDefault(e => e.Id == updateEmployee.Id);
            if (employee == null)
            {
                return;
            }
            employee.Name = updateEmployee.Name;
            employee.PhoneNumber = updateEmployee.PhoneNumber;
            employee.Dob = updateEmployee.Dob;
            employee.Gender = updateEmployee.Gender;
            employee.Email = updateEmployee.Email;
            MoveToListEmployeeView();
        }

        [RelayCommand]
        public void DeleteEmployee(string id)
        {
            var removeEmployee = RootData.FirstOrDefault(e => e.Id == id);
            if (removeEmployee != null)
            {
                RootData.Remove(removeEmployee);
                SearchEmployee();
            }
        }

        [RelayCommand]
        public void SubmitAddEmployeeForm(EmployeeModel employee)
        {
            if (employee != null)
            {
                var lastEmployee = RootData.LastOrDefault();
                if (lastEmployee == null)
                {
                    return;
                }
                var lastId = Convert.ToInt32(lastEmployee.Id.Replace("EMP0", ""));
                var newId = lastId + 1;
                employee.Id = "EMP0" + newId;
                RootData.Add(employee);
                var messenger = WeakReferenceMessenger.Default;
                messenger.Send(new SubmitAddEmployeeFormMessage("AddEmployeeSuccess"));
                SearchEmployee();
            }
        }
    }
}
