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
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Collections
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<UserDetails> UserList { get; set; }
        public string str { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            List<UserDetails> UList=new List<UserDetails>();

            //UserList = new ObservableCollection<UserDetails>()
            //{
            //    new UserDetails(){UserId = 1,Fname = "a",Lname = "b",PhoneNo=9019221911},
            //    new UserDetails(){UserId = 2,Fname = "c",Lname = "i",PhoneNo=9019286911},
            //    new UserDetails(){UserId = 3,Fname = "d",Lname = "j",PhoneNo=9258221911},
            //    new UserDetails(){UserId = 4,Fname = "e",Lname = "k",PhoneNo=9019221911},
            //    new UserDetails(){UserId = 5,Fname = "f",Lname = "l",PhoneNo=9019267911},
            //    new UserDetails(){UserId = 6,Fname = "g",Lname = "m",PhoneNo=9619451911},
            //    new UserDetails(){UserId = 7,Fname = "h",Lname = "n",PhoneNo=9819221913}
            //};

           UList.Add(new UserDetails()
            {
               UserId = 1,
                Fname = "a",
                Lname = "b",
                PhoneNo = 9019221911,
                Pid = null
           });
            UList.Add(new UserDetails()
            {
                UserId = 2,
                Fname = "c",
                Lname = "i",
                PhoneNo = 9019286911,
                Pid = null

            });
            UList.Add(new UserDetails()
            {
                UserId = 3,
                Fname = "d",
                Lname = "j",
                PhoneNo = 9258221911,
                Pid = null

            });
            UList.Add(new UserDetails()
            {
                UserId = 4,
                Fname = "e",
                Lname = "k",
                PhoneNo = 9019221911,
                Pid = 1

            });
            UList.Add(new UserDetails()
            {
                UserId = 5,
                Fname = "f",
                Lname = "l",
                PhoneNo = 9019267911,
                Pid = 1

            });
            UList.Add(new UserDetails()
            {
                UserId = 6,
                Fname = "a",
                Lname = "b",
                PhoneNo = 9019221911,
                Pid = 2

            });
            UList.Add(new UserDetails()
            {
                UserId = 7,
                Fname = "c",
                Lname = "i",
                PhoneNo = 9019286911,
                Pid = 2

            });

            UList.ForEach((v => v.Children = UList.Where(u => u.Pid.Equals(v.UserId)).ToList())) ;
            this.UserList = UList.Where(v => !v.Pid.HasValue).ToList();

           

            //Tv.ItemsSource = UserList;
            DataContext = this;

        }
        public void OnTreeViewItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            Dg.SelectedItem = e.NewValue;
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression b = Tv.GetBindingExpression(TextBox.TextProperty);
            b.UpdateSource();
            
        }
    }
}
