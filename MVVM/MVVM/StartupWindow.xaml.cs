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

namespace MVVM
{
    /// <summary>
    /// Interaction logic for StartupWindow.xaml
    /// </summary>
    public partial class StartupWindow : Window
    {
        public StartupWindow()
        {
            InitializeComponent();
            string[] menu = new string[3] {"Add a Player","View Teams", "Delete a Player" };
            Combobox_Menu.ItemsSource = menu;
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (Combobox_Menu.SelectedItem.ToString())
            {
                case "Add a Player":
                    {
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.ShowDialog();
                        break;
                    }

                case "View Teams":
                    ViewTeams viewTeams = new ViewTeams();
                    viewTeams.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}
