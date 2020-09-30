using MailKlient.Controls;
using MailKlient.Models;
using MailKlient.Views;
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

namespace MailKlient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public object contactList { get; }

        public MainWindow()
        {
            InitializeComponent();           
        }

        private void btnMessage_Click(object sender, RoutedEventArgs e)
        {
            DataContext= new MessageControl() ;
        }

        private void btnContact_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ContactModControl();
        }

        private void btnCalendar_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Calendar();
        }

        private void btnTask_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new TaskMod();
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new SettingsMod();
        }        
    }
} 