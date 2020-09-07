using System;
using System.Collections.Generic;
using System.Text;

namespace C15_Abstract_2.Models
{
    abstract class Device //ska ha funk.

    {
      public string CreateFromConnectionString(string connectionstring)
        {
            return $"Initializing conection with \"{connectionstring}\"";
        }

        //  METOD 
        //deklarerad hear men konfigurera(implementera) i  TempSensor
        public abstract string ReceiveMessage(); 
        public abstract void SendMessage(string payload); 
    }
}
