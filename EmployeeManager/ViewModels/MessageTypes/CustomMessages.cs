using CommunityToolkit.Mvvm.Messaging.Messages;
using EmployeeManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.ViewModels.MessageTypes
{
    public class AddNewEmployeeMessage : ValueChangedMessage<EmployeeModel>
    {
        public AddNewEmployeeMessage(EmployeeModel employee) : base(employee)
        {
        }
    }

    public class SubmitAddEmployeeFormMessage : ValueChangedMessage<string>
    {
        public SubmitAddEmployeeFormMessage(string value) : base(value)
        {
        }
    }
}
