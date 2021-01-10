using CommunicationAndCommonsLibrary.Core.Models;
using CommunicationAndCommonsLibrary.Core.Requests;
using CommunicationAndCommonsLibrary.HR.Models;
using CommunicationAndCommonsLibrary.HR.Requests;
using CommunicationAndCommonsLibrary.Payroll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public static async Task DeleteRowAsync<T>(BaseRequestHandler<T> handler, DataGrid dataGrid) where T : BaseEntity {
            if (DialogHelper.Delete()) {
                T selectedItem = (T)dataGrid.SelectedItem;
                await handler.DeleteAsync(selectedItem.Id);
                dataGrid.ItemsSource = handler.Get();
            }
        }

        public static int GetIndexOfComboboxValue(int id, ComboBox comboBox) {
            if (id == 0)
                return 0;
            return comboBox.ItemsSource.OfType<KeyValuePair<int, string>>()
                    .Select(x => x.Key).ToList().IndexOf(id);
        }

        public static Dictionary<int, string> ConvertToDictionary(Employee employee) =>
            new Dictionary<int, string>() { { employee.Id, string.Format($"{employee.LastName} {employee.FirstName}") } };

        public static Dictionary<int, string> ConvertToDictionary(EmployeeSimplified employee) =>
            new Dictionary<int, string>() { { employee.Id, string.Format($"{employee.LastName} {employee.FirstName}") } };

        public static Dictionary<int, string> ConvertToDictionary(Advance advance) =>
            new Dictionary<int, string>() { { advance.Contract.Id, string.Format($"{advance.Employee.LastName} {advance.Employee.FirstName} {advance.Contract.Number}") } };


        public static Dictionary<int, string> GetLocations() {
            var locations = new LocationRequestHandler().Get();
            Dictionary<int, string> output = locations.ToDictionary(x => x.Id, x => x.Name);
            return output;
        }

        public static Dictionary<int, string> GetForemen(int locationId = 0) {
            var foremen = new ForemanRequestHandler().Get();
            if (locationId != 0)
                foremen = foremen.Where(x => x.LocationId == locationId);
            Dictionary<int, string> output = foremen.ToDictionary(x => x.Id, x => string.Format($"{x.LastName} {x.FirstName}"));
            return output;
        }

        public static List<string> GetEmployeeHistory(int employeeId) {
            var history = new EmployeeRequestHandler().GetEmployeeHistory(employeeId);
            List<string> output = history.Select(x => string.Format($"{x.CreatedOn.ToString("yyyy-MM-dd")}")).ToList();
            return output;
        }
    }
}
