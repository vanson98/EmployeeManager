using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using EmployeeManager.Models;
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
            messenger.Send(new AddNewEmployeeMessage(NewEmployee));
        }
    }
}
