using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Enums;
using SystemSpecs.Core.Hardware;

namespace SystemSpecs.View.UserControls
{
    /// <summary>
    /// Interaction logic for OverviewContainer.xaml
    /// </summary>
    public partial class UsageContainer : UserControl, INotifyPropertyChanged
    {
        public static DependencyProperty DeviceTypeProperty = 
            DependencyProperty.Register("DeviceType", typeof(HardwareType), typeof(UsageContainer));

        public static DependencyProperty DeviceNameProperty =
            DependencyProperty.Register("DeviceName", typeof(string), typeof(UsageContainer));

        public static DependencyProperty DeviceTemperatureProperty =
            DependencyProperty.Register("DeviceTemperature", typeof(double), typeof(UsageContainer));

        public static DependencyProperty DeviceTemperatureUnitProperty =
            DependencyProperty.Register("DeviceTemperatureUnit", typeof(string), typeof(UsageContainer));

        public static DependencyProperty ResourceUnitProperty =
            DependencyProperty.Register("ResourceUnit", typeof(string), typeof(UsageContainer));

        public static DependencyProperty ResourceUsageProperty =
            DependencyProperty.Register("ResourceUsage", typeof(double), typeof(UsageContainer));

        public static DependencyProperty ResourceTotalProperty =
            DependencyProperty.Register("ResourceTotal", typeof(double), typeof(UsageContainer));

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
                return ResourceTotal == 0 ? 0 : Math.Round(100 * ResourceUsage / ResourceTotal, 2);
            }
        }

        private bool _IsExpanded;
        public bool IsExpanded
        {
            get
            {
                return _IsExpanded;
            }
            set
            {
                _IsExpanded = value;
                NotifyPropertyChanged();
            }
        }

        private BaseHardware _Hardware;

        public IEnumerable<object> MyProperties
        {
            get
            {
                foreach(string prop in DisplayedPropertiesConfig.NetworkAdapterDefaultDisplayedProperties)
                {
                    yield return new { Property = prop, Value = _Hardware.GetProperty(prop)?.ToString() };
                }
            }
        }

        public RelayCommand ExpandCollapseCommand { get; private set; }

        public UsageContainer(BaseHardware hardware)
        {
            DataContext = this;
            _Hardware = hardware;

            ExpandCollapseCommand = new RelayCommand(() => IsExpanded = !IsExpanded);

            InitializeComponent();
        }

        public void NotifyPropertyChanged([CallerMemberName] string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}