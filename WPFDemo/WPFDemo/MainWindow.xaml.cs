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


namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string name = "abc";
            this.DataContext = name;
            Movie_Details Det = new Movie_Details();
            List<Movie_Details> Movie_List = new List<Movie_Details>()
            {
               new Movie_Details(){Movie_Name="Inception" },
               new Movie_Details(){Movie_Name="The Martian" }
            };
            string[] Movie_Arr = new string[5] { "a", "b", "c", "d", "e"};
           
           // comboBox.ItemsSource = Movie_Arr;
           

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow window = new NavigationWindow
            {
                Source = new Uri("Page1.xaml", UriKind.RelativeOrAbsolute)
            };
            window.Show();           
            this.Close();
            
        }
        public class Movie_Details
        {
            public string Movie_Name { get; set; }
         //   public int Movie_Id { get; set; }
        }
    }
}
