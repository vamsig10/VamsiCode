﻿using System;
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

namespace EntityFramework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (var cx = new Class1())
            {


                var class3 = new Class3()
                {
                    Id = 1,
                    Name = "a"

                };
                cx.Class3S.Add(class3);

                var class3a = new Class3()
                {
                    Id = 2,
                    Name = "b"

                };
                cx.Class3S.Add(class3a);

                cx.SaveChanges();

             
            }


        }
    }
}
