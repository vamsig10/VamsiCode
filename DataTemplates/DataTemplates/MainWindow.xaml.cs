using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Resources;

namespace DataTemplates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Employee> Emp
        {
            get;
            set;
        }
        public MainWindow()
        {
            InitializeComponent();
            


            ObservableCollection<Employee> emp = new ObservableCollection<Employee>();

            emp.Add(new Employee { Fname = "Mark",  Lname = "Allain" });
            emp.Add(new Employee { Fname = "Allen", Lname = "Brown" });
            emp.Add(new Employee { Fname = "Linda", Lname = "Hamerski" });

            Emp = emp;
            DataContext = this;


        }
    }

  
}
