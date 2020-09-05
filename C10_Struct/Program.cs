using System;

namespace C10_Struct
{

    class Program
    { // bygga en struck / på samma sett som vanlig class


        struct Person
        { //  skapa  grupp av  variable
            public string Name { get; set; }   
            public int Age { get; set; }     
            public string City { get; set; }
        }


        static void Main(string[] args)
        {
            //var person = new Person();   - i class 
            Person person = new Person();

            Console.Write("Welcome Dude ! What`s your person.Name?  ");   //göra dialog. fråga nån 
            person.Name = Console.ReadLine();                          // lägger in .Name


            Console.Write($"{person.Name} :) How old are you?  ");
            // person.Age = Convert.ToInt32(  Console.ReadLine());    //  måste göra convertering string - int 
            // person.Age = int.Parse(Console.ReadLine());    // andra sätt--- likadant


            try
            {
                person.Age = Convert.ToInt32(Console.ReadLine()); // försök hear string- int
            }

            catch
            {
                Console.WriteLine("Sorry man ! You must---, try again. ");    // catching fel och skriver ut
                Console.Write("How old are you man ?  ");

                try
                {
                    person.Age = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Are you damb?   ");
                }

            }
            finally
            {
                Console.WriteLine($"oh cool  ! we are the same person.Age. I am also { person.Age } yo.{person.Name} ");
            }

            Console.WriteLine($"oh cool  ! we are the same person.Age. I am also {person.Age} yo. ");
            Console.WriteLine($"Dude your person.Name contains { person.Name.Length } characters!");
            Console.Write($"{person.Name} where do you live?  ");
            person.City = Console.ReadLine();
            Console.WriteLine($"Nice! My sister live in {person.City} .  ");
        }
    }
}
