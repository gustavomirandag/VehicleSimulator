using Domain.Model;
using Domain.Model.Pilots;
using Domain.Model.Vehicles;
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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Simulator MySimulation { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            MySimulation = new Simulator(new Driver("Senna"), new Mazda());
        }

        private void btnSpeedUp_Click(object sender, RoutedEventArgs e)
        {
            lbSpeed.Content = MySimulation.SpeedUp();
        }

        private void btnSpeedDown_Click(object sender, RoutedEventArgs e)
        {
            lbSpeed.Content = MySimulation.SpeedDown();
        }
    }
}
