using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MVVM
{
    /// <summary>
    /// Interaction logic for ViewTeams.xaml
    /// </summary>
    public partial class ViewTeams : Window
    {
        public ViewTeams()
        {
            InitializeComponent();
            string[] plaFranchise = new string[8] { "MI", "RCB", "KKR", "SRH", "RPS", "RR", "CSK", "DD" };
            Combobox_Teams.ItemsSource = plaFranchise;
           // CustomControlDemo cc=new CustomControlDemo();
          

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ControlDemoButton.Visibility = Visibility.Visible;

        }

        

        private void UserControlDemo_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void CustomControlDemo_Click_1(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Custom Control Button");

        }
    }
}
