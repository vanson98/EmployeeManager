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
        public required string Id { get; set; }
        public required string Name { get; set; }
        public string Email { get; set; }
        public DateTime Dob { get; set; }
        public required EmployeeRole Role { get; set; }
        public DateTime CreatedDate { get; set; }
        public required EmployeeStatus Status { get; set; }
    }
}
