using System;

namespace C12_Interfaces_1
{  // gör implementering


    class Program
    {
        static void Main(string[] args)
        {
            var cnc = new CNC();
            cnc.Start();
            cnc.Stop();



            Console.WriteLine("Hello World!");
        }
    }
}
