using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace EmployeeManager.Controls.Converter
{
    public class DateTimeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is DateTime datetime)
            {
                return datetime.ToString("dd/MM/yyyy");
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string dateString && DateTime.TryParseExact(dateString,"dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime result))
            {
                return result;
            }
            return DateTime.Now;
        }
    }
}
