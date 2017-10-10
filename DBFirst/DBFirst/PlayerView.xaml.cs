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
using System.Windows.Shapes;

namespace DBFirst
{
    /// <summary>
    /// Interaction logic for PlayerView.xaml
    /// </summary>
    public partial class PlayerView : Window
    {
         PlayerViewModel Details =new PlayerViewModel();

        public PlayerView()
        {
            InitializeComponent();
            string[] plaRole = new string[4] { "Batsman", "Bowler", "Wicket Keeper", "Allrounder" };
            ComboboxRole.ItemsSource = plaRole;
            string[] plaFranchise = new string[8] { "MI", "RCB", "KKR", "SRH", "RPS", "RR", "CSK", "DD" };
            ComboboxFranchise.ItemsSource = plaFranchise;
            DataContext = Details;
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            PlayerViewModel obj=new PlayerViewModel(Details);
        }
    }
}
