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

namespace MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            
            InitializeComponent();
            
            string[] plaRole = new string[4] { "Batsman", "Bowler", "Wicket Keeper", "Allrounder" };
            Combobox_Role.ItemsSource = plaRole;
            string[] plaFranchise = new string[8] { "MI", "RCB", "KKR", "SRH", "RPS", "RR", "CSK", "DD" };
            Combobox_Franchise.ItemsSource = plaFranchise;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Player_Details obj = new Player_Details
            {
                Id = Convert.ToInt32(Textbox_Id.Text),
                PlaName = Textbox_Name.Text,
                Age = Convert.ToInt32(Textbox_Age.Text),
                Role = Combobox_Role.SelectedValue.ToString(),
                Franchise = Combobox_Franchise.SelectedValue.ToString()
            };


            ViewModel viewModel = new ViewModel();
           


            viewModel.Enter_Player_Details(obj);
        }
    }
}
