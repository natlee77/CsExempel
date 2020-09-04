using System;
using System.Collections.Generic;
using System.Text;

namespace C5_WithAgeCalculation
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string NameContains { get; set; }
        public DateTime DateOfBirth { get; set; }


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
        public void AskForDateOfBirth()
        {
            Console.Write("When were you born?  ");

            try
            {
                DateOfBirth = Convert.ToDateTime(Console.ReadLine()); // försök convertera - date
            }

            catch
            {
                Console.Write("Sorry man ! I mean yyyy-mm-dd, try again. ");    // catching fel och skriver ut
                Console.Write("When were you born?  ");

                try
                {
                    DateOfBirth = Convert.ToDateTime(Console.ReadLine()); 
                }
                catch
                {
                    Console.WriteLine("Are you idiot?");
                }

            }

            Console.WriteLine($"OO cool , we are the same age I am also {CalculateAge()}");
        }

        private int CalculateAge()   // bara for den class- funktion calculera older
        {
            Age = DateTime.Now.Year - DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
            {                        // om bara en string inte obligatorisk brackets
                Age = Age - 1;
            }
            return Age;
        }
    }
}
