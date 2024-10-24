﻿string again = "a";
while(again == "a") {
            Console.WriteLine("*******************************************");
            Console.WriteLine("***** Generátor pseudonáhodných čísel *****");
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

            int kladna = 0;
            int zaporna = 0;
            int nula = 0;
            int suda = 0;
            int licha = 0;

            Console.WriteLine("\n\nNáhodná čísla");
            for(int i = 0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0};", myArray[i]);

                //if(myArray[i] > 0)
                //    kladna++;
                //if(myArray[i] < 0)
                //    zaporna++;
                //if(myArray[i] == 0)
                //    nula++;  

                if(myArray[i]>0)
                    kladna++;
                else if(myArray[i]<0)
                    zaporna++;
                else
                    nula++;              


                // sudá, lichá
                if(myArray[i] % 2 == 0)
                    suda++;
                else
                    licha++;    
            }
            
            Console.WriteLine("\n\nPočet kladných čísel: {0}", kladna);
            Console.WriteLine("Počet záporných čísel: {0}", zaporna);
            Console.WriteLine("Počet nul: {0}", nula);

            Console.WriteLine("Počet sudých čísel: {0}", suda);
            Console.WriteLine("Počet lichých čísel: {0}", licha);
        
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu napište A");
            again=Console.ReadLine();
    }
