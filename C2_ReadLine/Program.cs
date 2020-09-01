using System;

namespace C2_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty ;             //variable decklarerd,( tar minne i ram, decklarera när vi behöver)
            int age ;

            Console.Write("Welcome Dude ! What`s your name?  ");   //göra dialog. fråga nån 
            name = Console.ReadLine();                          // lässer en rad tecken


            Console.Write( $"{name} :) How old are you?  ");
            // age = Convert.ToInt32(  Console.ReadLine());    //  måste göra convertering string - int 
            // age = int.Parse(Console.ReadLine());    // andra sätt--- likadant


            try
            {
                age = Convert.ToInt32(Console.ReadLine()); // försök hear string- int
            }

              catch
            {
                Console.WriteLine( "Sorry man ! You must---, try again. ");    // catching fel och skriver ut
                Console.Write( "How old are you man ?  ");

                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Are you damb?   "  );
                }

            }
            finally
            {
                Console.WriteLine($"oh cool  ! we are the same age. I am also { age } yo.{name} ");
            }
            
            Console.WriteLine( $"oh cool  ! we are the same age. I am also {age} yo. ");
            Console.WriteLine( $"Dude your name contains { name.Length } characters!");
            Console.Write( $"{name} where do you live?  ");
            var city = Console.ReadLine();
            Console.WriteLine($"Nice! My sister live in {city} .  ");
        }
    }
}
