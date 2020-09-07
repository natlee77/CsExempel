using C13_Interfaces_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_2.Models
{
    class License : IShoppingItem, ILicense
        // har 2 st interface- vi kan ha so mycket som helst /arv kan ha bara 1
    {

        public string Name { get; set; }
        public int NumberOfLicense { get; set; } = 1;

        public string Id { get; set; }
        public string Discription { get; set; }

        public bool OrderCompleted { get; private set; }

        public void ShippingItem() // funk.
        {
            Console.WriteLine($"Licensen för {Name} har skickats till e-postadressen");
        }
    }
}
