using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MvvmDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Fname_TextChanged(object sender, TextChangedEventArgs e)
        {
            DbUtil util = new DbUtil();
            util.SelectDetails();
            DataContext = this;
        }

        public void B1_OnClick(object sender, RoutedEventArgs e)
        {
            DbUtil util = new DbUtil();

            util.SelectDetails();
            DataContext = this;
        }
    }
}
