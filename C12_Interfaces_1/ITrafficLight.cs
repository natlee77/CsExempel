using System;
using System.Collections.Generic;
using System.Text;

namespace C12_Interfaces_1
{
    interface ITrafficLight
    {// den funktionalitet ska traffic ljuset ha
        

        // implementera olika properties:
        Guid Id { get; set; }  // global idintifacation
        string Location { get; set; }


        void ChanchLight();
        void WarningLight();

    }
}
