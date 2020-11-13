using System;
using System.Globalization;
using System.Windows.Data;

namespace Desktop.UI.Core.ValueConverters {
    class ToPLNConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            string valueStr = value.ToString();
            if (string.IsNullOrEmpty(valueStr))
                return string.Empty;

            return string.Format($"{valueStr} PLN");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }

    }
}
