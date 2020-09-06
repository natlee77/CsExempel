using Microsoft.VisualBasic.CompilerServices;
using System;

namespace C11__Enum
{
    public enum Level // som Class
    {  // fasta värdet- constanta värdet- aldrig ändras
       //  kan stå under "Namespace" eller i "Class  program"

        Low,
        Normal,
        High
        
    }
    class Program
    {
        enum Status     // class nivå för enum
        {
           Pending, 
           Production,
           Transporting,
           Delivering
        }

        // använding enum - exemple temperature sensor
        static void Main(string[] args)
        {

            var temperature = 32; //motsvara High
            var _templevel = Level.Normal;


            //switch eller If -kan jämföra 
            switch (temperature)  //  olika nivå
            {
                case var t when t < 10:  //declarera variable( int eller var)
                    _templevel = Level.Low;                   
                    break;
                
                case var t when t > 30:
                    _templevel = Level.High;                  
                    break;

                default:                
                     _templevel = Level.Normal;
                      break;
            }
            switch(_templevel)
            {
                case Level.Low:
                    Console.WriteLine("Temperature is too Low ");
                    break;
                case Level.Normal:
                    Console.WriteLine("Temperature is Normal ");
                    break;
                case Level.High:
                    Console.WriteLine("Temperature is too High ");
                    break;
            }

            //Console.WriteLine(_templevel);

            var status = Status.Transporting;
            switch (status)
            {
                case Status.Pending:
                    Console.WriteLine("Electronic information has been received");
                    break;
                case Status.Production:
                    Console.WriteLine("Your product(s) are beeing preperad for shipping");
                    break;
                case Status.Transporting:
                    Console.WriteLine("Your product(s) are in transit");
                    break;
                case Status.Delivering:
                    Console.WriteLine("Your product(s) has been delivered");
                    break;
            }

        }
    }
}
