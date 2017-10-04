using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public TeamsModel TeamsModel { get; set; }

        public ViewTeams()
        {
            this.DataContext = TeamsModel;
            InitializeComponent();
            string[] plaFranchise = new string[8] { "MI", "RCB", "KKR", "SRH", "RPS", "RR", "CSK", "DD" };
            ComboboxTeams.ItemsSource = plaFranchise;
            TeamsModel =new TeamsModel();

        }

        

        private void UserControlDemo_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void CustomControlDemo_Click_1(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Custom Control Button");

        }

        private void ComboboxTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DbUtilViewTeams dbUtilViewTeams = new DbUtilViewTeams();
            TeamsModel.Names = dbUtilViewTeams.Retreive_Team_details(ComboboxTeams.SelectedItem.ToString());
            DataContext = TeamsModel.Names;
        }
    }
}
