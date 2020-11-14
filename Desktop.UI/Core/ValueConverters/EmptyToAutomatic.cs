using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Desktop.UI.Core.ValueConverters {
    public class EmptyToAutomatic : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            string valueStr = value?.ToString();
            if (string.IsNullOrEmpty(valueStr))
                return "Automatyczny";

            return valueStr;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            string valueStr = value?.ToString();
            if (valueStr == "Automatyczny")
                return null;

            return valueStr;
        }
    }
}