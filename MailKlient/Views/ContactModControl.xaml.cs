using MailKlient.Controls;
using System;
using System.Collections.Generic;
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

namespace MailKlient.Views
{
    /// <summary>
    /// Interaction logic for ContactModControl.xaml
    /// </summary>
    public partial class ContactModControl : UserControl
    {
        public ContactModControl()
        {

        }

        public ContactModControl(object contactList)
        {
            InitializeComponent();
            DataContext = new ContactControl();
            
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
