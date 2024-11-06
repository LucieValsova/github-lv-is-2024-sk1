
string again = "a";
while(again == "a") {
            Console.WriteLine("*******************************************");
            Console.WriteLine("************ Maximum a minimum ************");
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

            Console.WriteLine("Náhodná čísla");
            for(int i = 0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0};", myArray[i]);
            }

            int max = myArray [0];
            int min = myArray [0];
            int pmax = myArray [0];
            int pmin = myArray [0];

            for (int i = 1; i < n; i++) {
                if(myArray[i] > max) {
                    max = myArray[i]; 
                }
                if(myArray[i] < min) {
                    min = myArray[i];
                }
            }

            Console.WriteLine ("\n\nMaximum = {0}", max);
            Console.WriteLine ("První pozice Maxima v poli = {0}", pmax);
            Console.WriteLine ("\nMinimum = {0}", min);
            Console.WriteLine ("První pozice Minima v poli = {0}", pmin);


            Console.WriteLine();
            Console.WriteLine("Pro opakování programu napište A");
            again=Console.ReadLine();
    }
