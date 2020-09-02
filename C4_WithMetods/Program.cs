using System;

namespace C4_WithMetods
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.AskForName();  // kör funktion från Person.cs-metod AskForName(ask name)
            person.AskForAge();
            person.AskForNameContains();
            person.AskForCity();
        }
    }
}
