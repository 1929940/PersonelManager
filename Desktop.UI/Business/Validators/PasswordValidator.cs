using System.Globalization;
using System.Windows.Controls;

namespace Desktop.UI.Business.Validators {
    public class PasswordValidator : ValidationRule {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo) {
            string input = (string)value;
            if (input?.Length > 5)
                return new ValidationResult(false, "Musi zawierać przynajmiej 6 znaków.");
            return ValidationResult.ValidResult;
        }
    }
}
