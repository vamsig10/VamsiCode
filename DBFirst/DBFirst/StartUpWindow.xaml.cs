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
    /// Interaction logic for StartUpWindow.xaml
    /// </summary>
    public partial class StartUpWindow : Window
    {
        public StartUpWindow()
        {
            InitializeComponent();
            string[] menu = new string[5] { "Add a Player", "View Teams", "Delete a Player", "Add Franchise", "Display Data" };
            ComboboxMenu.ItemsSource = menu;

        }

        public void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (ComboboxMenu.SelectedItem.ToString())
            {
                case "Add a Player":
                    PlayerView playerView = new PlayerView();
                    playerView.ShowDialog();
                    break;
                case "Delete a Player":

                case "View Teams":
                //    ViewTeams viewTeams = new ViewTeams();
                 //   viewTeams.ShowDialog();
                    break;
                case "Add Franchise":
                    MainWindow mainWindow=new MainWindow();
                    mainWindow.ShowDialog();
                 
                    break;
                case "Display Data":
                    DisplayView displayView = new DisplayView();
                    displayView.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}

