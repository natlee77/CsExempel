using C13_Interfaces_2.Interfaces;
using C13_Interfaces_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_2.Helpers
{
    class SampleData
    {  public static List<IShoppingItem> CartSampleItems()  //---byta  ut Product till IShoppingItem
       // public static List<Product> CartSampleItems()    //funk. med list 

        {//skapa en Class Product i Models

            // var output = new List<Product>(); --- byta  ut Product till IShoppingItem
            var output = new List<IShoppingItem>();

            //lägga in olika product:
            //1
            output.Add(new Product { Id = "1005511", Name = "Apple Airpods(2019)", Description = "Airpods med laddningsetui" });
            output.Add(new Product { Id = "10044311", Name = "Apple (2018)", Description = "data" });
            output.Add(new Product { Id = "1005611", Name = "odastream Genesis", Description = "kol...." });
            output.Add(new Product { Id = "1005711", Name = "Day vatten flaska 500 ml", Description = "last flaska" });
            
            // 2 --fungera med implementeing IShopingItem, men inte med Product
            output.Add(new License { Id = "535868", Name = "Microsoft.W10....", Discription="Programm ....", NumberOfLicense = 4 }) ;
            return output;
        }
    }  /* efter bytad vi Product till IShopingItem - list funkar, 
        * de imlementerad ,även att de är class Product,de  får plats*/
}
