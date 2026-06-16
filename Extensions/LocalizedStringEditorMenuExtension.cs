using LocalizedStringStudioPlugin.Controls;
using Frosty.Core;
using System.Windows.Media;

namespace LocalizedStringStudioPlugin.Extensions
{
    public class LocalizedStringViewerMenuExtension : MenuExtension
    {
        internal static ImageSource imageSource = new ImageSourceConverter().ConvertFromString("pack://application:,,,/LocalizedStringStudioPlugin;component/Images/LocalizedStringEditor.png") as ImageSource;

        public override string TopLevelMenuName => "View";

        public override string MenuItemName => "Localized String Studio";

        public override ImageSource Icon => imageSource;

        public override RelayCommand MenuItemClicked => new RelayCommand((o) =>
        {
            App.EditorWindow.OpenEditor("Localized String Studio", new LocalizedStringEditor());
        });
    }
}
