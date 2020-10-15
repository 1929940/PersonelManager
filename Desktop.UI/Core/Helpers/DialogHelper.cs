using Desktop.UI.Core.Resources;
using System.Windows;

namespace Desktop.UI.Core.Helpers {
    public class DialogHelper {
        public static bool Save() => MessageBox.Show(Messages.CONFIRM_SAVE, Messages.CONFIRM, MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes;
        public static bool Close() => MessageBox.Show(Messages.CONFIRM_EXIT, Messages.CONFIRM, MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes;
        public static bool Delete() => MessageBox.Show(Messages.CONFIRM_DELETE, Messages.CONFIRM, MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes;
    }
}
