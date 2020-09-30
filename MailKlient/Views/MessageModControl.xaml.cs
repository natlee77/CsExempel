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
    /// Interaction logic for MessageModControl.xaml
    /// </summary>
    public partial class MessageModControl : UserControl
    {
        public MessageModControl()
        {
            InitializeComponent();
        }

        private void messageButton_Click(object sender, RoutedEventArgs e)
        {
            time.Text = " ond 8.66";
            subject.Text = " Påminelse";
            from.Text = "";
            to.Text = "Nataliya Lisjö";
            body.Text = "chfyujgiklhlbjhgigkgvhvkhg";

        }
    }
}
