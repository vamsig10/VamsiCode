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
    /// Interaction logic for UserControlDemo.xaml
    /// </summary>
    public partial class UserControlDemo : UserControl
    {
        public UserControlDemo()
        {            
            InitializeComponent();
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Button_Team_Click(object sender, RoutedEventArgs e)
        {
            ListView1.Visibility = Visibility.Visible;
            string[] a = new string[2] { "a", "b" };
            ListView1.ItemsSource = a;         
        }
    }
}
