using System;
using System.Collections.Generic;
using System.Text;

namespace C12_Interfaces_1
{
   public interface IMachine  // namn på kontraktet
    {  // finnas 2 saker
        bool Start();  // ska finss "start" funk.,som retunera ett bool värde
        bool Stop();
       // void Reset(); // en funk., som inte retunera nån
       // ska implementera de 2 start-stop
    }

}
