﻿using CommunicationLibrary.Core.Logic;
using CommunicationLibrary.Core.Models;
using CommunicationLibrary.HR.Models;
using CommunicationLibrary.HR.Requests;
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

        public static int GetIndexOfComboboxValue(int id, ComboBox comboBox) {
            if (id == 0)
                return 0;
            return comboBox.ItemsSource.OfType<KeyValuePair<int, string>>()
                    .Select(x => x.Key).ToList().IndexOf(id);
        }

        public static Dictionary<int, string> GetEmployeesDictionary() =>
            new EmployeeRequestHandler().Get().ToDictionary(x => x.Id, x => string.Format($"{x.LastName} {x.FirstName}"));
    }
}