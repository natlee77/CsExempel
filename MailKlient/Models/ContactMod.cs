using System;
using System.Collections.Generic;
using System.Text;

namespace MailKlient.Models
{
    class ContactMod
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $" {FirstName } {LastName}";
        public string EmailAdress { get; set; }
    }
}
