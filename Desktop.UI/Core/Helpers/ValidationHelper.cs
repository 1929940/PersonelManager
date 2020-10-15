using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Desktop.UI.Core.Helpers {
    public class ValidationHelper {
        private static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject {
            if (depObj != null) {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++) {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T) {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child)) {
                        yield return childOfChild;
                    }
                }
            }
        }

        public static bool AreTextboxesValid(DependencyObject depObt) {
            var textboxes = FindVisualChildren<TextBox>(depObt);
            bool result = true;

            foreach (var textbox in textboxes) {
                textbox.GetBindingExpression(TextBox.TextProperty).UpdateSource();
                if (Validation.GetHasError(textbox))
                    result = false;
            }
            return result;
        }

    }
}
