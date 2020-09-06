using System;
using System.Collections.Generic;
using System.Text;

namespace C12_Interfaces_1
{
    //implementera basic funktionalitet for mashine från IMashine.cs i class CNC
    class CNC : IMachine

    {
        public bool Start()
        {
            Console.WriteLine("CNC mashine has startad");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("CNC mashine has stopped");
            return true;
        }
    }
}
