using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
    /// Interaction logic for DataDisplayView.xaml
    /// </summary>
 
    public partial class DataDisplayView : Window
    {
        public List<PlayerModel> Dc { get; set; }

        //public DbUtilRetreive obj=new DbUtilRetreive();

        public DataDisplayModel DataDisplayModel { get; set; }
        public DataDisplayView()
        {
            InitializeComponent();

        }
        public void Display(ObservableCollection<PlayerModel> list)
        {
            DataDisplayModel = new DataDisplayModel {Data = list};
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            B1.Visibility = Visibility.Hidden;
            DbUtilRetreive dbUtilRetreive = new DbUtilRetreive();
            var temp=dbUtilRetreive.Retreive_Player_Details();
            DataContext = temp;
        }
    }
}
