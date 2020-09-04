using System;
using System.Collections.Generic;
using System.Text;

namespace C6_Get_Set
{
    class Person
    {
        public string Name { get; private set; }
        public int Age  => CalculateAge(); //  read only/if it 1 parameter
        public string City { get; private set; }
        public string NameContains { get; set; }
        public DateTime DateOfBirth { get; private set; }


        public void AskForName()  //public metod- for att nå från Programm
        {
            Console.Write("Welcome Dude ! What`s your Name?  ");
            Name = Console.ReadLine();

            Console.Write($"{Name} :) Nice  ");
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

            Console.WriteLine($"Ooo! cool , we are the same age I am also {Age}");
        }
        private int CalculateAge()   // bara for den class- funktion calculera older
        {
            int _age = DateTime.Now.Year - DateOfBirth.Year; // _ (intern  private variable)
            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
            {                        // om bara en string inte obligatorisk brackets
                Console.WriteLine(Age);
                _age = _age - 1;
            }
            return _age;
        }
    }
}
