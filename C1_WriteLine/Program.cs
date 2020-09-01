using System;

namespace C1_WriteLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nata";
            int age = 49;
            var city = "Degerfors";

            var text1 = "Welcome Nata! You are 49 years old , right? Nata do you live in Degerfors?";
            var text2 = "Welcome" +name+"! You are " +age+" years old , right? "+name+" do you live in"+city+"?";
            var text3 = String.Format("Welcome {0}! You are {1} years old , right? {0} do you live in {2}?",name,age,city);
            var text4 = $"Welcome Nata! You are 49 years old , right? Nata do you live in Degerfors?";

            Console.WriteLine(text1);
            Console.WriteLine(text2);
            Console.WriteLine(text3);
            Console.WriteLine(text4);
        }

    }
}
