using System;
using System.Collections.Generic;
using System.Text;

namespace C14_Abstract_1.Models
{ 
   abstract  class Person
    // abstract -förhindra att nån kan skapa en person i Programm.cs

    {// i den  1 person har:

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
