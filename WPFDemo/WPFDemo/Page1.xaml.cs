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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Person Person { get; set; }
        public Person Person2 { get; set; }

        public Page1()
        {
            InitializeComponent();
            Person = new Person();
            Person2 = new Person();
            DataContext = this;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow window = new NavigationWindow();
            window.Source = new Uri("Page2.xaml", UriKind.RelativeOrAbsolute);
            window.Show();


        }
    }
}
