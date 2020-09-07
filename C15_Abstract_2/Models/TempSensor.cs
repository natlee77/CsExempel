using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace C15_Abstract_2.Models
{
    class TempSensor : Device
    {
        public override string ReceiveMessage()
            // override - kan se det är från abstract class, men configureras här

        { /*instalera extention--Tools-- NyGetPackageManager--Manage NGPM for soluion:
           install Newtonsoft.Jons i Astract-2  */


            //JSON = {"command":"get"}
            var message = JsonConvert.DeserializeObject<dynamic>("{\"command\":\"get\"}");
            // ta Json-object och göra om C#-object
            // dynamic - tar här och skapa automatisk class på sidan
            // command har värdet get
            return message.command;
        }

        public override void SendMessage(string payload)
        {
            Console.WriteLine($"Sending message: {payload}");
        }
    }
}
