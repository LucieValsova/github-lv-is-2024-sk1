﻿string again = "a";
while(again == "a") {
            Console.WriteLine("*******************************************");
            Console.WriteLine("***** Intervaly pseudonáhodných čísel *****");
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
            
            //deklarace pole
            int [] myArray = new int[n];
            Random randomNumber = new Random();

            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            
            Console.WriteLine("\n\nNáhodná čísla");
            for(int i = 0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0};", myArray[i]);

               if (myArray[i]<= (0.25*hm)) {
                a++;
               }    
               else if (myArray[i]<= (0.5*hm)) {
                b++;
               }  
               else if (myArray[i]<= (0.75*hm)) {
                c++;
               }    
               else
                d++;
            }
            
            Console.WriteLine ("\n\nPočet čísel v intervalu <{0}, {1}>: {2}", dm, 0.25 * hm, a);  
            Console.WriteLine ("Počet čísel v intervalu <{0}, {1}>: {2}", 0.25 * hm + 1, 0.5 * hm, b); 
            Console.WriteLine ("Počet čísel v intervalu <{0}, {1}>: {2}", 0.5 * hm + 1, 0.75 * hm, c); 
            Console.WriteLine ("Počet čísel v intervalu <{0}, {1}>: {2}", 0.75 * hm + 1, hm, d); 
        
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu napište A");
            again=Console.ReadLine();
    }
