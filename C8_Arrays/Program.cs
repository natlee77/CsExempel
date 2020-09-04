using System;
using System.Reflection.Metadata;

namespace C8_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many sibling do you have? ");
            var _numberOfSiblings = Convert.ToInt32(Console.ReadLine());
            if (_numberOfSiblings < 1)
                Console.WriteLine("Okey. That`s cool! ");

            else          //flera styck / deklarera array
            {
                string[] siblings = new string[_numberOfSiblings];
                if (_numberOfSiblings == 1)
                {
                    Console.WriteLine("cool! ");
                    Console.Write("what`s your sibling name?  ");
                    siblings[0] = Console.ReadLine();
                }
                else

                {                                            //"FOR" loop i-index
                    for (var i = 0; i < _numberOfSiblings; i++)  // <-condition som mäste upnås
                    {                                         //++ inkrimintering
                        if (i == 0)
                            Console.WriteLine("What`s your first sibling name? ");
                        else
                            Console.Write(" And your next sibling name is? ");

                        siblings[i] = Console.ReadLine();
                    }

                }
                if (_numberOfSiblings == 1)
                    Console.WriteLine(" So correct me if I am wrong . Your sibling is  ");
                else
                    Console.WriteLine(" So correct me if I am wrong . Your sibling are  ");
                foreach (var sibling in siblings)                      //foreach loop
                {
                    Console.Write($"{sibling},  ");  //$-placehålder in {} 
                }
            }

            
        }
    }
}                /* operations:
                 = tilldela ett värdet
                 += lägg till på befintlig(существующее) värde
                 -= ta bort från befintlig värde
                
                 == lika med
                 != inte lika med 
                 ! inte
                 ||  eller
                 && och
                  <= mindre eller lika med
                 */
