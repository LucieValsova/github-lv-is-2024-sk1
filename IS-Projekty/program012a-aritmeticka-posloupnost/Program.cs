﻿string again = "a";
while(again == "a") {
            Console.WriteLine("*******************************************");
            Console.WriteLine("********* Aritmetická posloupnost *********");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*************** Lucie Valsová *************");
            Console.WriteLine("*******************************************");
            Console.WriteLine();
            Console.Write("Zadejte počet generovaných čísel (celé číslo):");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet generovaných čísel znovu:");
            }
            Console.Write("Zadejte dolní mez řady (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
            }
            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
            }
            Console.WriteLine();
            Console.WriteLine("=======================================================");
            Console.WriteLine("Zadané hodnoty");
            Console.WriteLine("Počet čísel: {0}; dolní mez {1}; horní mez {2}", n, dm, hm);
            Console.WriteLine("=======================================================");
            Console.WriteLine();
            
            
            
        
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu napište A");
            again=Console.ReadLine();
    }