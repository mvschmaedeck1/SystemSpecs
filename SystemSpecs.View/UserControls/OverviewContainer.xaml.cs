using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using SystemSpecs.Core.Enums;

namespace SystemSpecs.UI.UserControls
{
    /// <summary>
    /// Interaction logic for OverviewContainer.xaml
    /// </summary>
    public partial class OverviewContainer : UserControl, INotifyPropertyChanged
    {
        public static DependencyProperty DeviceTypeProperty = 
            DependencyProperty.Register("DeviceType", typeof(HardwareType), typeof(OverviewContainer));

        public static DependencyProperty DeviceNameProperty =
            DependencyProperty.Register("DeviceName", typeof(string), typeof(OverviewContainer));

        public static DependencyProperty DeviceTemperatureProperty =
            DependencyProperty.Register("DeviceTemperature", typeof(double), typeof(OverviewContainer));

        public static DependencyProperty DeviceTemperatureUnitProperty =
            DependencyProperty.Register("DeviceTemperatureUnit", typeof(string), typeof(OverviewContainer));

        public static DependencyProperty ResourceUnitProperty =
            DependencyProperty.Register("ResourceUnit", typeof(string), typeof(OverviewContainer));

        public static DependencyProperty ResourceUsageProperty =
            DependencyProperty.Register("ResourceUsage", typeof(double), typeof(OverviewContainer));

        public static DependencyProperty ResourceTotalProperty =
            DependencyProperty.Register("ResourceTotal", typeof(double), typeof(OverviewContainer));

        public event PropertyChangedEventHandler PropertyChanged;

        public HardwareType DeviceType
        {
            get
            {
                return (HardwareType) GetValue(DeviceTypeProperty);
            }
            set
            {
                SetValue(DeviceTypeProperty, value);
            }
        }
        public string DeviceName
        {
            get
            {
                return (string)GetValue(DeviceNameProperty);
            }
            set
            {
                SetValue(DeviceNameProperty, value);
            }
        }
        public double DeviceTemperature
        {
            get
            {
                return (double) GetValue(DeviceTemperatureProperty);
            }
            set
            {
                SetValue(DeviceTemperatureProperty, value);
            }
        }
        public string DeviceTemperatureUnit
        {
            get
            {
                return (string)GetValue(DeviceTemperatureUnitProperty);
            }
            set
            {
                SetValue(DeviceTemperatureUnitProperty, value);
            }
        }

        public string ResourceUnit
        {
            get
            {
                return (string)GetValue(ResourceUnitProperty);
            }
            set
            {
                SetValue(ResourceUnitProperty, value);
            }
        }
        public double ResourceUsage
        {
            get
            {
                return (double)GetValue(ResourceUsageProperty);
            }
            set
            {
                SetValue(ResourceUsageProperty, value);
                NotifyPropertyChanged("ResourcePercentUsage");
            }
        }
        public double ResourceTotal
        {
            get
            {
                return (double)GetValue(ResourceTotalProperty);
            }
            set
            {
                SetValue(ResourceTotalProperty, value);
                NotifyPropertyChanged("ResourcePercentUsage");
            }
        }
        public double ResourcePercentUsage
        {
            get
            {
                return Math.Round(100 * ResourceUsage / ResourceTotal, 2);
            }
        }

        public OverviewContainer()
        {
            InitializeComponent();
        }

        public void NotifyPropertyChanged([CallerMemberName] string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}