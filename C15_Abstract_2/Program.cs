using C15_Abstract_2.Models;
using System;

namespace C15_Abstract_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var tempsensor = new TempSensor();
            Console.WriteLine( tempsensor.CreateFromConnectionString("HostName=iot.azure.com;DeviceId=dev"));
            Console.WriteLine();

            var command = tempsensor.ReceiveMessage();
            //den apparaten få meddelande skickat till sig. ska lässa den :

            Console.WriteLine($"Reseived Command : {command}");

            switch(command)
            {
                case "get":
                    tempsensor.SendMessage("temperature=12");
                    break;
                case "Reset":
                    tempsensor.SendMessage("Device has been reset");
                    break;
                default:
                    tempsensor.SendMessage("Command not implemented");
                    break;
            }

        }
    }
}
