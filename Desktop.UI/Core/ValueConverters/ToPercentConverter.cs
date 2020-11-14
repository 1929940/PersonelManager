using System;
using System.Globalization;
using System.Windows.Data;

namespace Desktop.UI.Core.ValueConverters {
    class ToPercentConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            string valueStr = value.ToString();
            if (string.IsNullOrEmpty(valueStr))
                return string.Empty;

            return string.Format($"{valueStr}%");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            string valueStr = value.ToString();
            int indexOfPercentSymbol = valueStr.LastIndexOf('%');
            if (indexOfPercentSymbol == -1) {
                if (Decimal.TryParse(valueStr, out _)) {
                    valueStr += '%';
                    indexOfPercentSymbol = valueStr.LastIndexOf('%');
                } else {
                    return 0;
                }
            }
            valueStr = valueStr.Substring(0, indexOfPercentSymbol);

            decimal result = Decimal.Round(Decimal.Parse(valueStr), 2);
            if (result > 100 || result < 0)
                return 0;

            return result;
        }
    }
}