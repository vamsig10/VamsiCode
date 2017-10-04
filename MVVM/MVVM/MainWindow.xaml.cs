using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Navigation;

namespace MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public PlayerViewModel Details { get; set; }
        public MainWindow()
        { 
            InitializeComponent();           
            string[] plaRole = new string[4] { "Batsman", "Bowler", "Wicket Keeper", "Allrounder" };
            ComboboxRole.ItemsSource = plaRole;
            string[] plaFranchise = new string[8] { "MI", "RCB", "KKR", "SRH", "RPS", "RR", "CSK", "DD" };
            ComboboxFranchise.ItemsSource = plaFranchise;

            InitializeData();
           
        }

        protected void InitializeData()
        {
            var model = new PlayerModel();
            Details = new PlayerViewModel(model);
            DataContext = this;
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
           // Save();
           Details.Save();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        //    this.NavigationService.
        }

        //public void Save()
        //{
        //    // db util cannot be in view as per MVVM
        //    DBUtil util = new DBUtil();
        //    util.Enter_Player_Details("IPL", );
        //}
    }
}
