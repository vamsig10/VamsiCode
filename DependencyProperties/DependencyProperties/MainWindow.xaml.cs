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

namespace DependencyProperties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Demo
        {
            get { return (string) GetValue(DemoProperty); }
            set { SetValue(DemoProperty, value); }
        }

        public static  DependencyProperty DemoProperty = DependencyProperty.Register("Demo", typeof(string),
            typeof(MainWindow), new UIPropertyMetadata("Demo Prop"));
        
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          //  Tb.Text = DemoProperty.ToString();
            Demo = Tb.Text.ToString();
            MessageBox.Show(DemoProperty.ToString());
        }
    }
}
