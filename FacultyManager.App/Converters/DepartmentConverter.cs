using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace FacultyManager.Applicatiion.Converters
{
    public class DepartmentConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            switch (value.ToString())
            {
                case "1":
                    return "Department of Finance";
                case "2":
                    return "Department of Math";
                case "3":
                    return "Department of Physics";
                default:
                    return "Department not found.";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            switch (value.ToString().ToLower())
            {
                case "Department of Finance":
                    return "1";
                case "Department of Math":
                    return "2";
                case "Department of Physics":
                    return "3";
                default:
                    return "Department not found.";
            }
        }
    }
}
