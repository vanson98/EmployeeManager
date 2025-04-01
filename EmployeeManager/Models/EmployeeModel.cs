using EmployeeManager.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Models
{
    public class EmployeeModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public EmployeeGender Gender { get; set; } = EmployeeGender.Male;
        public DateTime CreatedDate { get; set; }
        public DateTime Dob { get; set; }
        public EmployeeRole Role { get; set; }
        public EmployeeStatus Status { get; set; }
        public int OnTime { get; set; }
        public int Late { get; set; }
        public int OnLeave { get; set; }
        public string AvatarPath { get; set; } // New property for profile picture
        public List<ProjectAttendance> ProjectAttendances { get; set; }
    }
}
