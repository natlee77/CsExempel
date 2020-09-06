using System;
using System.Collections.Generic;
using System.Text;

namespace C12_Interfaces_1
{
    class BandSaw : IMachine
    {
        public bool Start()
        {
            Console.WriteLine("BandSaw mashine has startad");
            return true;  //skriv funktionalitet
        }

        public bool Stop()
        {
            Console.WriteLine("BandSaw mashine has stopped");
            return true; 
        }
    }
}
