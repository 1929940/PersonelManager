using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace Desktop.UI.Core.Validators {
    public class EmailValidator : ValidationRule {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo) {
            string input = (string)value;
            if (!Regex.IsMatch(input, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase))
                return new ValidationResult(false, "Niepoprawny format adresu email.");
            return ValidationResult.ValidResult;
        }
    }
}
