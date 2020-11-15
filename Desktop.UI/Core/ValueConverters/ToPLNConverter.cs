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
            string valueStr = value.ToString();
            int currencySymbolIndex = valueStr.LastIndexOf(" PLN");
            if (currencySymbolIndex == -1) {
                if (Decimal.TryParse(valueStr, out _)) {
                    valueStr += " PLN";
                    currencySymbolIndex = valueStr.LastIndexOf(" PLN");
                } else {
                    return 0;
                }
            }
            valueStr = valueStr.Substring(0, currencySymbolIndex);
            if (string.IsNullOrEmpty(valueStr))
                return 0;
            return Decimal.Round(Decimal.Parse(valueStr), 2);
        }

    }
}
