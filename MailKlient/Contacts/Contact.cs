using System;
using System.Collections.Generic;
using System.Text;

namespace MailKlient.Contacts
{
      class Contact
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{FirstName}{LastName} "; // incapslad/ byggs automatisk

        public Contact(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
        
    }
}
