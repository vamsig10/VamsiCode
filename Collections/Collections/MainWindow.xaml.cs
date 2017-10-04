using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Collections
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<UserDetails> UserList { get; set; }
        // public List<Class1> DataGridDataContext { get; set; }

        SqlConnection conn;
        SqlCommand comm;
        public void Db_Open()
        {
            conn = new SqlConnection(@"Data Source=INHYZDPC35;Initial Catalog=Vamsi_Gamidi_DB; User id =sa; Password=sa; ");
            conn.Open();
        }
        public void Execute(string query)
        {
            comm.ExecuteNonQuery();
            conn.Close();
        }
       public MainWindow()
        {
            InitializeComponent();

            List<UserDetails> uList = new List<UserDetails>
            {
                new UserDetails()
                {
                    UserId = 1,
                    Fname = "Rohit",
                    Lname = "Sharma",
                    PhoneNo = 9019221911,
                    Pid = null
                },
                new UserDetails()
                {
                    UserId = 2,
                    Fname = "Virat",
                    Lname = "Kohli",
                    PhoneNo = 9019286911,
                    Pid = null

                },
                new UserDetails()
                {
                    UserId = 3,
                    Fname = "Yuvraj",
                    Lname = "Singh",
                    PhoneNo = 9258221911,
                    Pid = null

                },
                new UserDetails()
                {
                    UserId = 4,
                    Fname = "Manish",
                    Lname = "Pandey",
                    PhoneNo = 9019221911,
                    Pid = 1

                },
                new UserDetails()
                {
                    UserId = 5,
                    Fname = "Hardik",
                    Lname = "Pandya",
                    PhoneNo = 9019267911,
                    Pid = 1

                },
                new UserDetails()
                {
                    UserId = 6,
                    Fname = "Jasprit",
                    Lname = "Bumrah",
                    PhoneNo = 9019221911,
                    Pid = 2

                },
                new UserDetails()
                {
                    UserId = 7,
                    Fname = "Bhuvneshwar",
                    Lname = "Kumar",
                    PhoneNo = 9019286911,
                    Pid = 2

                }
            };

            uList.ForEach((v => v.Children = uList.Where(u => u.Pid.Equals(v.UserId)).ToList()));
            this.UserList = uList.Where(v => !v.Pid.HasValue).ToList();



            //Tv.ItemsSource = UserList;
            DataContext = this;
        }
        public void OnTreeViewItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            Dg.SelectedItem = e.NewValue;
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < Dg.Items.Count; i++)
            {
                var dataGridRow = (DataGridRow)Dg.ItemContainerGenerator.ContainerFromIndex(i);
                var dataGridCellsPresenter = GetVisualChild<DataGridCellsPresenter>(dataGridRow);
                for (int j = 0; j < Dg.Columns.Count; j++)
                {

                    var dataGridCell = (DataGridCell)dataGridCellsPresenter.ItemContainerGenerator.ContainerFromIndex(j);
                    var tb1 = FindVisualChild<TextBox>(dataGridCell, "tb1");
                    if (tb1 != null)
                    {
                        BindingExpression binding = BindingOperations.GetBindingExpression(tb1, TextBox.TextProperty);
                        binding?.UpdateSource();

                    }
                }
            }
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {


        }
        public static T GetVisualChild<T>(Visual parent) where T : Visual
        {
            Visual visual;
            T child = default(T);

            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < childrenCount; i++)
            {
                visual = (Visual)VisualTreeHelper.GetChild(parent, i);
                child = visual as T;
                if (child == null)
                {
                    child = GetVisualChild<T>(visual);
                }
                if (child != null)
                {
                    break;
                }
            }
            return child;
        }

        public T FindVisualChild<T>(DependencyObject obj, string name) where T : DependencyObject
        {
            DependencyObject child;
            FrameworkElement frameworkElement;
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                child = VisualTreeHelper.GetChild(obj, i);
                frameworkElement = child as FrameworkElement;
                if (child != null && child is T && frameworkElement != null && frameworkElement.Name == name)
                {
                    return (T)child;
                }
                else
                {
                    T childOfChild = FindVisualChild<T>(child, name);
                    if (childOfChild != null)
                    {
                        return childOfChild;
                    }
                }
            }

            return null;
        }
    }
}
