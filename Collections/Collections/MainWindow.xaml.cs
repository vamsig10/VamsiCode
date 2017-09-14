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

namespace Collections
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<UserDetails> UserList = new List<UserDetails>()
            {
                //new UserDetails(){UserId = 1,Fname = "a",Lname = "b",PhoneNo=9019221911},
                //new UserDetails(){UserId = 2,Fname = "c",Lname = "i",PhoneNo=9019286911},
                //new UserDetails(){UserId = 3,Fname = "d",Lname = "j",PhoneNo=9258221911},
                //new UserDetails(){UserId = 4,Fname = "e",Lname = "k",PhoneNo=9019221911},
                //new UserDetails(){UserId = 5,Fname = "f",Lname = "l",PhoneNo=9019267911},
                //new UserDetails(){UserId = 6,Fname = "g",Lname = "m",PhoneNo=9619451911},
                //new UserDetails(){UserId = 7,Fname = "h",Lname = "n",PhoneNo=9819221913}
                new UserDetails(){UserId = new int[3]{1,2,3},Fname = new string[3]{"a","b","c"},Lname = new string[3]{"d","e","f"},PhoneNo = new long[3]{123,456,789}}
            };
           

            DataContext = UserList;
        }
    }
}
