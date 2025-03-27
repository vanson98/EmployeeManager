using EmployeeManager.Models.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace EmployeeManager.Controls.Converter
{
    public class StringToEnumConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is string stringValue)
            {
                if(targetType == typeof(EmployeeRole) && Enum.TryParse(stringValue, out EmployeeRole role))
                {
                    return role;
                }
            }
            return EmployeeRole.Developer;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
