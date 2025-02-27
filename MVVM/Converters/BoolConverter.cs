using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_MVVM_Pattern.MVVM.Converters
{
    class BoolConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            string? answer = value?.ToString();
            if (answer?.Equals("si", StringComparison.OrdinalIgnoreCase) == true) return true;

            return false;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            bool? boolValue = (bool?)value;

            if (boolValue.HasValue && boolValue.Value) return "SI";
            return "NO";

        }
    }
}
