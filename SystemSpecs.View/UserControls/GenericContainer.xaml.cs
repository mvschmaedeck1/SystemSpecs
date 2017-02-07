using GalaSoft.MvvmLight.Command;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace SystemSpecs.View.UserControls
{
    /// <summary>
    /// Interaction logic for GenericContainer.xaml
    /// </summary>
    public partial class GenericContainer : UserControl
    {
        public static DependencyProperty IconProperty
            = DependencyProperty.Register("Icon", typeof(UIElement), typeof(GenericContainer));

        public static DependencyProperty TitleProperty
            = DependencyProperty.Register("Title", typeof(string), typeof(GenericContainer));


        public static DependencyProperty IsExpandedProperty
            = DependencyProperty.Register("IsExpanded", typeof(bool), typeof(GenericContainer), new FrameworkPropertyMetadata(true));

        public UIElement Icon
        {
            get
            {
                return GetValue(IconProperty) as UIElement;
            }
            set
            {
                SetValue(IconProperty, value);
            }
        }

        public string Title
        {
            get
            {
                return GetValue(TitleProperty) as string;
            }
            set
            {
                SetValue(TitleProperty, value);
            }
        }

        public bool IsExpanded
        {
            get
            {
                return (bool) GetValue(IsExpandedProperty);
            }
            set
            {
                SetValue(IsExpandedProperty, value);
            }
        }

        public RelayCommand ExpandCollapseCommand { get; private set; }

        public GenericContainer()
        {
            DataContext = this;

            ExpandCollapseCommand = new RelayCommand(() => IsExpanded = !IsExpanded);

            InitializeComponent();
        }
    }
}
