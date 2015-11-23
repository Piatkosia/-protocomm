using System;
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
using System.Windows.Shapes;

namespace protocomm
{
    /// <summary>
    /// Interaction logic for AddMethodWindow.xaml
    /// </summary>
    public partial class AddMethodWindow : Window
    {
        public AddMethodWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var obj = new protocommMethod()
            {
                Name = Methodname.Text,
            };
            StaticBank.ProtocommMethodList.Add(obj);
            Close();
        }
    }

   
}
