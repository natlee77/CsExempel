using System;

namespace C6_Get_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            // person.Name = "Nata";  //set
            // Console.WriteLine(person.Name); //GET
            person.AskForDateOfBirth();     // att köra function från PERSON.CS
            person.AskForName();
            Console.WriteLine(person.Name);
        }
    }
}
