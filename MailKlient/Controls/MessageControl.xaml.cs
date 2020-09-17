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

namespace MailKlient.Controls
{
    /// <summary>
    /// Interaction logic for MessageControl.xaml
    /// </summary>
    public partial class MessageControl : UserControl
    {
        public MessageControl()
        {
            InitializeComponent();
        }
        public ImageSource ContactImage
        {
            get { return contactImage.Source; }
            set { contactImage.Source = value; }
        }
        public string ContactName
        {
            get { return contactName.Text; }
            set { contactName.Text = value; }
        }
    }
}
