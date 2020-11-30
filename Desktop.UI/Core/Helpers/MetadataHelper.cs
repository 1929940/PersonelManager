using CommunicationLibrary.Core.Models;
using System.Windows;
using System.Windows.Controls;

namespace Desktop.UI.Core.Helpers {
    public class MetadataHelper {
        const string GROUP_BOX = "MetaDataGroupBox";
        const string CREATED_LABEL = "CreatedTextBlock";
        const string UPDATED_LABEL = "UpdatedTextBlock";

        public static void Init(Window form, bool editMode, BaseEntity entity) {
            if (!editMode || !AuthorizationHelper.Authorize(Enums.Roles.Kierownik))
                HideGroup(form);
            else {
                HandleCreatedLabel(form, entity);
                HandleUpdatedLabel(form, entity);
            }
        }

        private static void HideGroup(Window form) {
            GroupBox groupBox = form.FindName(GROUP_BOX) as GroupBox;
            groupBox.Visibility = Visibility.Collapsed;
            form.Height -= 65;
        }

        private static void HandleCreatedLabel(Window form, BaseEntity entity) {
            TextBlock textBlock = form.FindName(CREATED_LABEL) as TextBlock;

            if (string.IsNullOrEmpty(entity.CreatedBy)) 
                textBlock.Visibility = Visibility.Collapsed;
            textBlock.Text = string.Format($"Obiekt stworzony {entity.CreatedOn} przez {entity.CreatedBy}");
        }

        private static void HandleUpdatedLabel(Window form, BaseEntity entity) {
            TextBlock textBlock = form.FindName(UPDATED_LABEL) as TextBlock;

            if (string.IsNullOrEmpty(entity.UpdatedBy)) 
                textBlock.Visibility = Visibility.Collapsed;
            textBlock.Text = string.Format($"Ostatniej modyfikacji dokonano {entity.CreatedOn} przez {entity.CreatedBy}");
        }
    }
}
