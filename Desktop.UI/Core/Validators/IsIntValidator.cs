using System.Globalization;
using System.Windows.Controls;

namespace Desktop.UI.Core.Validators {
    public class IsIntValidator : ValidationRule {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo) {
            if (int.TryParse(value.ToString(), out int result) && result >= 0)
                return ValidationResult.ValidResult;

            return new ValidationResult(false, "Niepoprawna wartość.");
        }
    }
}
