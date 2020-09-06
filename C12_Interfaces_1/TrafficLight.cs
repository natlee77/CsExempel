using System;
using System.Collections.Generic;
using System.Text;

namespace C12_Interfaces_1
{   // min class förbereda  med de funk. som jag kan eimplementera ändringar utan use
    class TrafficLight : ITrafficLight 
    {
        public Guid Id { get; set ; }
        public string Location { get ; set ; }

        public void ChanchLight()
        {
            throw new NotImplementedException();
        }

        public void WarningLight()
        {
            throw new NotImplementedException();
        }
    }
}
