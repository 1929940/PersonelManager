using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Desktop.UI.Core.Validators {
    public class IsPercentValue : ValidationRule {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo) {
            if (double.TryParse(value.ToString(), out double result) && result >= 0 && result <= 100)
                return ValidationResult.ValidResult;

            return new ValidationResult(false, "Niepoprawna wartość. Podaj liczbę z zakresu 0-100");
        }
    }
}
