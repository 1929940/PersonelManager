using System.Globalization;
using System.Windows.Controls;

namespace Desktop.UI.Core.Validators {
    public class IsNotZeroPLNValidator : ValidationRule {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo) {
            string input = (string)value;
            if (string.IsNullOrEmpty(input) || input == "0 PLN")
                return new ValidationResult(false, "Uzupełnij");
            return ValidationResult.ValidResult;
        }
    }
}
