﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace protocomm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Showing.ItemsSource = StaticBank.ProtocommMethodList;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new AddMethodWindow().Show();
            Showing.Items.Refresh();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            Showing.Items.Refresh();
        }
    }
}
