using C14_Abstract_1.Models;
using System;
using System.Collections.Generic;

namespace C14_Abstract_1
{  /* 1- bygger up liten struktor- liten lista - catalog Models
    *  i Models   + class Person
    *  i Models  +  Class Teacher, som oxså Person (vanlig arv)
            och arvar alla saker som finns i Person.cs + andra saker "Role"
    *  i Models + class student  och arvar alla saker som finns i Person.cs 
             + andra saker "ClassName"
    *   nu arbetar med class Programm
    */

    class Program
    {          

        static void Main(string[] args)
        {
            var classlist = new List<Person>()
            {
             new Teacher {FirstName ="Hans", LastName="Mattison", Role= "Theacher"},
             new Student {FirstName="Nata", LastName="Lisjo"},
             new Student {FirstName="Anna", LastName="Anderson"}
            };

            //loop de
            foreach(var person in classlist)
            {
                if( person is Teacher teacher)
                Console.WriteLine($"{teacher.FirstName} {teacher.LastName}-{teacher.Role}");
                else
                Console.WriteLine($"{person.FirstName} {person.LastName}");
            }
            
        }
    }
}
