using System;
using System.Collections.Generic;
using System.Text;

namespace C4_WithMetods
{
    class Person
    {
        public string Name { get; set; }   
        public int Age { get; set; }     
        public string City { get; set; }
        public string NameContains { get; set; }


        public void AskForName()  //public metod- for att nå från Programm
        {
            Console.Write("Welcome Dude ! What`s your Name?  "); 
            Name = Console.ReadLine();           
            
            Console.Write($"{Name} :) Nice  ");
        }
        public void AskForAge()
        {
            Console.Write(" How old are you?  ");


            try
            {
                Age = Convert.ToInt32(Console.ReadLine()); // försök hear string- int
            }

            catch
            {
                Console.WriteLine("Sorry man ! You must, try again. ");    // catching fel och skriver ut
                Console.Write("How old are you man ?  ");

                try
                {
                   Age = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Are you damb?   ");
                }

            }
            finally
            {
                Console.WriteLine($"oh cool ! we are the same age. I am also {Age} yo.{Name}");
            }

        }

        public void  AskForNameContains()
        {
           Console.WriteLine($"your name contains {Name.Length } characters!");
        }
        public void AskForCity()
        {
            Console.Write($"{Name} where do you live? ");
            City = Console.ReadLine();
            Console.WriteLine($"Nice! My sister live in {City}.");
        }
    }
}
