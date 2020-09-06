using System;

namespace C10_Struct
{
    class ClassExemple
    {   // 2stuck attribut 
        public int Nr1 { get; set; }
        public int Nr2 { get; set; }


        // 1 ctor  med samma namn som class har - med function(metod) 
        public ClassExemple(int nr1, int nr2) // declarera - nr1,nr2
        {
            Nr1 = nr1;  //när matta in nr1 -automatisk gå Nr1
            Nr2 = nr2;
        }

        public void DisplayValues()    // 1 funktion
        {
            Console.WriteLine($"Display Values:{Nr1}, {Nr2} ");
        }
    }

    struct StruckExemple   //exect likadant som Class , bara namn
    {   // 2stuck attribut 
        public int Nr1 { get; set; }
        public int Nr2 { get; set; }


        // ctor  med samma namn som class har - med function(metod) 
        public StruckExemple(int nr1, int nr2) // declarera - nr1,nr2
        {
            Nr1 = nr1;  //när matta in nr1 -automatisk gå Nr1
            Nr2 = nr2;
        }

        public void DisplayValues()
        {
            Console.WriteLine($"Display Values:{Nr1}, {Nr2} ");
        }
    }

    // nu vi ska göra nånting med de (CLASS ; STRUCK) för att visa skilnad eller om de identiska
    //skilnd när kör andra gång "DisplayValues"
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ClassExemple -HEAP(GLOBAL)");// alt som jag sparar i HEAP är globala
            var classexemple = new ClassExemple(1, 1);

            classexemple.DisplayValues(); //function som skriver ut värderna
            ModifyValues(classexemple);  //tar och köra" ModifyValues" och skicka in "classexemple"
            classexemple.DisplayValues(); //kör andra gång

            Console.WriteLine("\n------------------------------------\n ");


            Console.WriteLine("StruckExample - STACK(LOCAL)");//alla saker i STACK -lokcala variable
            var struckexemple = new StruckExemple(1, 1);

            struckexemple.DisplayValues(); //function som skriver ut värderna
            ModifyValues(struckexemple);
            struckexemple.DisplayValues(); //2-a gång( samma värde utan modify)


            Console.ReadKey();
        }


        // en ny function:  static -därför att "static  void Main"
        private static void ModifyValues(dynamic d)// dynamisk--oavsett class eller struck jag köra
        {
            d.Nr1 += 1;
            d.Nr2 += 1;

            Console.WriteLine($"Modifying Values: {d.Nr1}, {d.Nr2}");
        }
        /* 
         int Nr1 =1  // ligger  i global
        function
        {
        Nr1 += 1; //local       dvs Nr1 =2
        }

         
         
         */
    }
}

