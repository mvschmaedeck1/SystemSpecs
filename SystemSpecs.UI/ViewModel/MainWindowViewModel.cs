using MahApps.Metro.Controls;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace SystemSpecs.UI.ViewModel
{
    public class MainWindowViewModel
    {
        public ObservableCollection<MetroTabItem> TabControlItems { get; private set; }

        public MainWindowViewModel()
        {
            TabControlItems = new ObservableCollection<MetroTabItem>();
        }
    }
}