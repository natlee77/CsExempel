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
using WPF1_ContactList.Models;

namespace WPF1_ContactList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void ClearFields()
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
        }       
    }
}
