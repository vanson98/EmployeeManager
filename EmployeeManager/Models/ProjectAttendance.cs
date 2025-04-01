using EmployeeManager.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Models
{
    public class ProjectAttendance
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Week { get; set; }
        public float WorkingHourPercent { get; set; }
        public EmployeeProject Project { get; set; }
    }
}
