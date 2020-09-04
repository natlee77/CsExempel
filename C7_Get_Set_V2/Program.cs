using System;

namespace C7_Get_Set_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
           
            person.AskForDateOfBirth();     // att köra function från PERSON.CS
            person.AskForName();
            Console.WriteLine(person.Name);
        }
    }
}
