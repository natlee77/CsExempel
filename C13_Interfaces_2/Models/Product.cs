using C13_Interfaces_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_2.Models
{
    class Product: IShoppingItem   // Product implementera IShoppingItem

    {// i den har olika properties// ska göra från de list i "SampleDate"

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool OrderComplited { get; private set; } //mer bättre  till order class:
        

        public bool OrderCompleted { get; private set; }
        public string Discription { get ; set ; }

       
        

        //controlera att order slutförs eller inte
        public void ShippingItem() // funk. -om order skickad iväg
        {
                                               //  =if(OrdetComplited !=true) V.3
            //if sats- kolla på true statement //  = if (OrderCompleted==false) V.2
            if (!OrderComplited) //om inte ordet complited-- tilstånd V.1
            {  
                Console.WriteLine($"Varan {Name} har skickats iväg.");
                OrderComplited = true;
            }
        }
    }
}
