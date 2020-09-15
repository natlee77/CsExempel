using System;
using System.Collections.Generic;
using System.Text;

namespace MailKlient.Models
{
    class NavigContactMod
    {
        
        public string FullName => $" {FirstName } {LastName}";
        public string EmailAdress { get; set; }
    }
}
