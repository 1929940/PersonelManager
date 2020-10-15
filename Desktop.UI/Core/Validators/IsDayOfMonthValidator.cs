using System.Globalization;
using System.Windows.Controls;

namespace Desktop.UI.Core.Validators {
    public class IsDayOfMonthValidator : ValidationRule {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo) {
            int result = int.Parse((string)value);
            if (result >= 1 && result <= 31)
                return ValidationResult.ValidResult;

            return new ValidationResult(false, "Niepoprawna wartość. Podaj liczbę z zakresu 1-31");
        }
    }
}
