using MahApps.Metro.Controls;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SystemSpecs.Helpers;
using System.Windows.Media;
using SystemSpecs.Infrastructure;

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

            var v = new NetworkAdaptersRepository();

            InitializeComponent();
        }
    }
}
