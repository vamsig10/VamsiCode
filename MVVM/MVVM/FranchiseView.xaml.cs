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

namespace MVVM
{
    /// <summary>
    /// Interaction logic for FranchiseView.xaml
    /// </summary>
    public partial class FranchiseView : Window
    {
        public FranchiseViewModel Details { get; set; }

        public FranchiseView()
        {
            InitializeComponent();
            InitializeData();

        }
        protected void InitializeData()
        {
            var model = new FranchiseModel();
            Details = new FranchiseViewModel(model);
            DataContext = this;
        }

        public void Submit_Click(object sender, RoutedEventArgs e)
        {
            Details.Save();

        }
    }
}
