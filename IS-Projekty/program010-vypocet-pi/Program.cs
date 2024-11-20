﻿using System;
using System.Data;

class Program {
    static void Main() {
        
        string again = "a";
        
        while(again == "a") {
            Console.WriteLine("*******************************");
            Console.WriteLine("*** Výpočet ludolfova čísla ***");
            Console.WriteLine("*******************************");
            Console.WriteLine("******** Lucie Valsová ********");
            Console.WriteLine("*******************************");
            Console.WriteLine();

            Console.Write("Zadejte přesnost (reálné číslo - čím menší hodnota, tím bude výpočet přesnější): ");
            double presnost;
            while(!double.TryParse(Console.ReadLine(), out presnost)) {
                Console.Write("Nezadali jste reálné číslo. Zadejte přesnost znovu: ");
            }

           double i = 1;
           double znamenko = 1;
           double piCtvrt = 1;

           while ((1/i) >= presnost) {
                i = i + 2;
                znamenko = -znamenko;
                piCtvrt = piCtvrt + znamenko * (1/i);

                if (znamenko==1) {
                    Console.Write("\nZlomek: +1/{0}     Aktuální hodnota PI = {1}", i, 4 * piCtvrt);
                }
                else {
                    Console.Write("\nZlomek: -1/{0}     Aktuální hodnota PI = {1}", i, 4 * piCtvrt);
                }
           }

           Console.WriteLine ("\n\nHodnota čísla PI = {0}", 4 * piCtvrt);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();

        }

    }
}    


    




// toto je jednořádkový komentář

/* toto je
víceřádkový
komentář
 */