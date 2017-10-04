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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public  Employee emp { get; set; }
        
        public MainWindow()
        {
            InitializeComponent();
            
            emp = new Employee
            {
                Fname = "First Name",
                Role = new[] { "Dev", "Test", "Maint", "HR" },
                Desc= "agfjhsdagfjhasdfjhv"
            };

            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string a = cb.SelectedItem.ToString();
            //MessageBox.Show(a);

            var controls=new controls();
            controls.ShowDialog();
           
        }
    }
}
