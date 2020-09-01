using System;

namespace C2_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = String.Empty ;

            Console.Write("Welcome ! what`s your name?")
                name = Console.ReadLine();
            Console.Write($ "{name}oh cool man ! we are the same age. I am also {age} {name}");

            int age


            try
            {
                age = Convert.ToInt32(Console.ReadLine()); 
            }

              catch
            {
                Console.WriteLine( "Sorry man ! You must ");
                Console.Write( "How old are you man ?");
            }
            finally
            {
               
            }
            Console.WriteLine($ "oh cool man ! we are the same age. I am also {age} {name}");
            Console.WriteLine($"Dude your name contains {name.Lenght} characters!");
            Console.Write($ "oh cool man ! we are the same age. I am also {age} {name}");
        }
    }
}
