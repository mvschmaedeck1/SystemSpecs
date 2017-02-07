using MahApps.Metro.Controls;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using SystemSpecs.Infrastructure.Repositories.NetworkDevices;
using SystemSpecs.Repository.Repositories.VideoAndMonitorDevices;
using SystemSpecs.View.UserControls;

namespace SystemSpecs.View.ViewModel
{
    public class MainWindowViewModel
    {
        public UIElement NetworkOverviewContent { get; set; }

        public MainWindowViewModel()
        {
            StackPanel x = new StackPanel();

            foreach(var adapter in NetworkAdaptersRepository.Instance.GetAll())
            {
                x.Children.Add(new UsageContainer(adapter) { DeviceName = adapter.GetProperty("Description").ToString() });
            }

            //NetworkOverviewContent = x;
        }
    }
}
