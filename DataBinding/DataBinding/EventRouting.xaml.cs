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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for EventRouting.xaml
    /// </summary>
    public partial class EventRouting : Window
    {
        public EventRouting()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text = "Button is Clicked";

        }
        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            txt2.Text = "Click event is bubbled to Stack Panel";
            
        }

        private void Window_Click(object sender, RoutedEventArgs e)
        {
            txt3.Text = "Click event is bubbled to Window";
        }
        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Window_PreviewKeyDown");
          //  e.Handled = true;
        }

        private void StackPanel_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("StackPanel_PreviewKeyDown");
           // e.Handled = true;
        }
        private void StackPanel_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show("StackPanel_KeyUp");
           // e.Handled = true;
        }

        private void StackPanel_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("StackPanel_KeyDown");
           // e.Handled = true;
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Window_KeyDown");
           // e.Handled = true;
        }

    }
}
