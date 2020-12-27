using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Desktop.UI.Core.ValueConverters {
    class ToHourConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            string valueStr = value.ToString();
            if (string.IsNullOrEmpty(valueStr))
                return string.Empty;

            return string.Format($"{valueStr} godz.");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            string valueStr = value.ToString();
            int currencySymbolIndex = valueStr.LastIndexOf(" godz.");
            if (currencySymbolIndex == -1) {
                if (Int32.TryParse(valueStr, out _)) {
                    valueStr += " godz.";
                    currencySymbolIndex = valueStr.LastIndexOf(" godz.");
                } else {
                    return 0;
                }
            }
            valueStr = valueStr.Substring(0, currencySymbolIndex);
            if (string.IsNullOrEmpty(valueStr))
                return 0;
            return Int32.Parse(valueStr);
        }

    }
}
