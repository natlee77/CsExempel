using MailKlient.Models;
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
        public MainWindow()
        {
            InitializeComponent();

            var contacts = new List<string>() { "Nata", "Niklas", "Anna" };
            foreach(var contact in contacts)
            {
                contactList.Children.Add(new Controls.ContactControl() { ContactName= contact } );
            }
            
        }

        private void btnMessage_Click(object sender, RoutedEventArgs e)
        {
            DataContext= new MessageMod() ;
        }

        private void btnContact_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ContactMod();
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
}  /*   private void ClearFields()
        {
            TbFirstName.Text = "";
            TbLastName.Text = "";
                
        }
        private void btnAddContact_Click(object sender, RoutedEventArgs e)
        {
            var contact = new Contact(TbFirstName.Text, TbLastName.Text);
            try
            {
                lbContactList.Items.Add(contact.FullName);
            }
            catch{ }
            finally // ska använda funk. ClearFields
            {
                ClearFields();
            }
        }
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lbContactList.Items.Remove(lbContactList.Items[lbContactList.SelectedIndex]);
                // lbContactList.SelectedIndex kan välja själv vad ska jag ta bort 
            }
            catch { }
        }        */
