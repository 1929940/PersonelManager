using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Desktop.UI.Core.Validators {
    public class PeselValidator : ValidationRule {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo) {
            string pesel = (string)value;
            if (IsCorrectLenght(pesel) && IsCheckSumCorrect(pesel))
                return ValidationResult.ValidResult;

            return new ValidationResult(false, "Niepoprawny Pesel.");
        }

        private bool IsCorrectLenght(string value) => value.Length == 11;

        private bool IsCheckSumCorrect(string value) {
            int[] mask = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 0 };
            int sum = 0;
            int checkValue = 0;

            for (int i = 0; i < 11; i++) {
                if (Int32.TryParse(value[i].ToString(), out int digit)) {
                    sum += (digit * mask[i]) % 10;
                } else
                    return false;
            }
            checkValue = (10 - (sum % 10));
            return checkValue.ToString() == value.Last().ToString();
        }
    }
}
