using System;
using System.Collections.Generic;
using System.Text;

namespace C3_WithClass
{
    class Person  //ska använd inom project inte public, alt om en person
    {                                       // first  
        public string Name { get; set; }   //skapa 3 st properties-object,ska public-acessbara. de altid på samma ställe
        public int Age { get; set; }     //de är tomt utan konstruktor. det är fördel for Class, instället att använda variable
        public string City { get; set; }


        public Person()          // standart tomt konstruktor (ctor) i Class
        {

        }           
        
    }
   

}
