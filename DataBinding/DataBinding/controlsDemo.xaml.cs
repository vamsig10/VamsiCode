using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaction logic for controls.xaml
    /// </summary>
    public partial class controls : Window
    {
        public Employee Emp { get; set; }
        public List<Employee> list { get; set; }
        public controls()
        {
            InitializeComponent();
            CommandBinding copyCommand = new CommandBinding(ApplicationCommands.Copy, Copy_executed, Copy_canexecuted);
            CommandBinding pasteCommand = new CommandBinding(ApplicationCommands.Paste, Paste_executed, Paste_canexecuted);
            this.CommandBindings.Add(copyCommand);
            this.CommandBindings.Add(pasteCommand);

            Emp = new Employee();
             list=new List<Employee>
            {
                new Employee(){Fname = "a",Lname = "f",Desc = "g"},
                new Employee(){Fname = "b",Lname = "e",Desc = "h"},
                new Employee(){Fname = "c",Lname = "d",Desc = "i"}
                
            };
              DataGrid1.ItemsSource = list;

           //DataGrid1.DataContext = this;
        }

        private void Paste_canexecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !string.IsNullOrWhiteSpace(copiedText);
        }

        private void Paste_executed(object sender, ExecutedRoutedEventArgs e)
        {
            //Tb.Text += copiedText;
            Tb.Text += Clipboard.GetText();
        }

        private string copiedText = string.Empty;
        private void Copy_canexecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Copy_executed(object sender, ExecutedRoutedEventArgs e)
        {
            
            copiedText = string.Empty;
            copiedText = Tb.SelectedText;
        }
        
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void EventRouting_Click(object sender, RoutedEventArgs e)
        {
            var eventRouting = new EventRouting();
            eventRouting.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var bubblingDemo = new BubblingDemo();
            bubblingDemo.ShowDialog();
        }
        
    }
}
