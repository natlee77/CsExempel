using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_2.Interfaces
{
    // contract- jag tala om, hur ser "shopingItem" ut, vad är 
   public interface IShoppingItem  
    {
        string Id { get; set; }
        string Name { get; set; }
        string Discription { get; set; }
        

        bool OrderCompleted { get; }

        void ShippingItem(); // license och Producter likadant
    }
}
