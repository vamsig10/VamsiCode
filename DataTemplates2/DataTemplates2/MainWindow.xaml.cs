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

namespace DataTemplates2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Players> PlaList { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            PlaList=new List<Players>()
            {
                new Players(){Fname = "Vamsi",JerseyNo = 10},
                new Players(){Fname = "Rohit",JerseyNo = 45},
                new Players(){Fname = "Virat",JerseyNo = 18},
            };
            DataContext = this;
        }
    }
}
