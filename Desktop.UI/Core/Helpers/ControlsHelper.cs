using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Linq;
using System;

namespace Desktop.UI.Core.Helpers {
    public class ControlsHelper {
        private static IEnumerable<T> GetVisualChildren<T>(DependencyObject depObj) where T : DependencyObject {
            if (depObj != null) {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++) {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T && child.DependencyObjectType.Name == typeof(T).Name) {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in GetVisualChildren<T>(child)) {
                        if (childOfChild.DependencyObjectType.Name == typeof(T).Name)
                            yield return childOfChild;
                    }
                }
            }
        }

        private static IEnumerable<DependencyObject> GetAllVisualChildren(DependencyObject depObj) {
            if (depObj != null) {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++) {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null) {
                        yield return child;
                    }

                    foreach (DependencyObject childOfChild in GetAllVisualChildren(child)) {
                        yield return childOfChild;
                    }
                }
            }
        }

        public static void DisableControls(DependencyObject depObt, string[] ignored) {

            List<Control> controls = GetAllVisualChildren(depObt).Where(x => !(x is GroupBox)).OfType<Control>().ToList();

            List<Control> ignoredControls = controls.Where(x => ignored.Contains(x.Name)).ToList();

            List<Control> ignoredChildren = new List<Control>();
            foreach (var ignoredControl in ignoredControls) {
                ignoredChildren.AddRange(GetAllVisualChildren(ignoredControl as DependencyObject).OfType<Control>());
            }

            ignoredControls.AddRange(ignoredChildren);

            controls.Except(ignoredControls).ToList()
                .ForEach(x => { x.IsHitTestVisible = false; x.Focusable = false; });
        }

        public static bool AreTextboxesValid(DependencyObject depObt) {
            var textboxes = GetVisualChildren<TextBox>(depObt);
            bool result = true;

            foreach (var textbox in textboxes) {
                textbox.GetBindingExpression(TextBox.TextProperty)?.UpdateSource();
                if (Validation.GetHasError(textbox))
                    result = false;
            }
            return result;
        }

    }
}
