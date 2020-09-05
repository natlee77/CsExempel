using System;
using System.Collections.Generic;

namespace C9_Listor
{
    class Program
    {
        static void Main(string[] args)
        {
            bool _hasSiblings;
            Console.Write("Do you have any siblings(yes/no) ");
            var _SiblingsResponce = Console.ReadLine();

            switch(_SiblingsResponce.ToLower())
            {
                case " yes":
                    _hasSiblings = true;
                    break;

                case "no":
                    _hasSiblings = false;
                    break;

                 default:
                    _hasSiblings = false;
                    break;                                       
            }

            if (!_hasSiblings) //!- inte 
            
                Console.WriteLine("Okey , Cool! ");
            else
            {
                Console.WriteLine("Okey ,Nice! How many siblings do you have? ");              
                int _numberOfSiblings = Convert.ToInt32(Console.ReadLine());

                var siblings = new List<string>();

                if (_numberOfSiblings == 1)
                {
                    Console.Write("what`s your sibling name?  ");
                    siblings.Add (Console.ReadLine());

                    Console.Write($"Okey!! so your sibling name is {siblings[0]}  ");
                   
                }
                else                // om jag har flera styck sibling , jag repetera igen
                {
                    Console.Write(" What¨s your sibling names? Separera med comm (,) ");
                    var _responce = Console.ReadLine();

                    var names = _responce.Replace(" ", " ").Split(","); /* hämta alla namn.
                                                                         * ta bort mellan slag
                                                                         * lägga till in List*/
                    foreach ( var name in names)
                    {
                        siblings.Add(name);
                    }


                    // ska sortera - den som äldre first i lista( göra med array)
                    Console.Write("Which of your siblings are the oldest? ");
                    var _oldest = Console.ReadLine();

                    var index = siblings.FindIndex(x => x.Contains(_oldest)); // lambda expressions
                    siblings.RemoveAt(index); //lista kommer sortera nu automatisk
                    siblings.Insert(0, _oldest);

                    Console.Write("Ok,So your simbling name  are   ");
                    foreach(var sibling in siblings)
                    {
                        Console.Write($"{sibling}");
                    }
                }
            }
        }     
       
    }
}

