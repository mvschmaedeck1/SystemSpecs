using MahApps.Metro.Controls;
using SystemSpecs.Helpers;
using System.Windows.Media;
using SystemSpecs.Infrastructure.Repositories.NetworkDevices;

namespace SystemSpecs.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            ThemeManagerHelper.CreateAppStyleBy(Brushes.Brown.Color, true);

            InitializeComponent();
        }
    }
}
