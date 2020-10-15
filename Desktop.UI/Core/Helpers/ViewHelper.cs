using CommunicationLibrary.Core.Logic;
using CommunicationLibrary.Core.Models;
using CommunicationLibrary.HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Desktop.UI.Core.Helpers {
    public class ViewHelper {

        public static bool IsDocWithinSearchParams(string input, object item) {
            PersonelDocument doc = item as PersonelDocument;

            if (string.IsNullOrEmpty(input))
                return true;

            return doc.Employee.FirstName.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || doc.Employee.LastName.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || doc.Employee.Profession.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || doc.Title.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || doc.Number.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0
                || doc.IssuedBy.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        public static async Task DeleteRow<T>(BaseRequestHandler<T> handler, DataGrid dataGrid) where T : BaseEntity {
            if (DialogHelper.Delete()) {
                T selectedItem = (T)dataGrid.SelectedItem;
                await handler.DeleteAsync(selectedItem.Id);
                dataGrid.ItemsSource = handler.Get();
            }
        }
    }
}
