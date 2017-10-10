using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for DisplayView.xaml
    /// </summary>
   
    public partial class DisplayView : Window
    {
        private readonly SaveChanges _saveChanges;
        private ObservableCollection<PlayerViewModel> Coll { get; set; }


        public DisplayView()
        {
            InitializeComponent();
            Coll=new ObservableCollection<PlayerViewModel>();

            _saveChanges=new SaveChanges(Coll);
            DataContext = Coll;

        }


        private void SaveButton_OnClick(object sender, RoutedEventArgs e)
        {
            _saveChanges.SaveToDb();

        }


    }

 }
    

