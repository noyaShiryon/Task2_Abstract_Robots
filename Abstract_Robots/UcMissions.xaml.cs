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

namespace Robots_inc
{
    /// <summary>
    /// Interaction logic for UcMissions.xaml
    /// </summary>
    public partial class UcMissions : UserControl
    {
        Worker worker;
        Mission misson;
        public UcMissions(Worker worker, Mission misson)
        {
            InitializeComponent();
        }

        private void btnCamera_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMove_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnFinish_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
