using C13_Interfaces_2.Helpers;
using C13_Interfaces_2.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace C13_Interfaces_2
{
    class Program //skapa new köping cart
    {
        static void Main(string[] args)
        {
            //list med producter - våran köping cart-jag populera med färdig data(list)
            var cart = SampleData.CartSampleItems();


            //loppar igenom den list med ShipingItem funk. från class Product

            foreach (var item in cart)
            //  v2
            {
                item.ShippingItem();
                if (item is ILicense license)// om det type av Ilicense 
                    // då  vill Jag skriva
                    Console.WriteLine($"Du har {license.NumberOfLicense}st. license att använda ");
            }
        }
    }
}
