using System.Diagnostics;
using System.IO.Pipelines;

string again = "a";
while(again == "a") {
            Console.WriteLine("*******************************************");
            Console.WriteLine("************ Kombinovaná úloha ************");
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
            Console.WriteLine("\n\n=======================================================");
            Console.WriteLine("\nZadané hodnoty");
            Console.WriteLine("\nPočet čísel: {0}; dolní mez {1}; horní mez {2}", n, dm, hm);
            Console.WriteLine("\n=======================================================");
            Console.WriteLine();
            
            //deklarace pole
            int [] myArray = new int[n];
            Random randomNumber = new Random();


            Console.WriteLine("\nNáhodná čísla");
            for(int i = 0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0};", myArray[i]);
            }

                  int max = myArray [0];
            int min = myArray [0];
            string maxPozice = "";
            string minPozice = "";


            for (int i = 1; i < n; i++) {
                if(myArray[i] > max) {
                    max = myArray[i]; 
                }
                if(myArray[i] < min) {
                    min = myArray[i];
                }
            }

            for (int i = 1; i<n; i++){
                if(myArray[i]==max) {
                    maxPozice +=","+i;
                }
                if(myArray[i]==min) {
                    minPozice +=","+i;
                }
            }

            Console.WriteLine("\n\n==============================================");
            Console.WriteLine("\n\nMaximum = {0}; jeho  pozice v poli =  {1}", max, maxPozice);
            Console.WriteLine("Minimum = {0}; jeho pozice v poli = {1}", min, minPozice); 
    


         // Insertion sort
       
        Stopwatch stopky1 = new Stopwatch();
        stopky1.Start();

      for (int i = 0; i < myArray.Length - 1; i++)
      {
        int j = i + 1;
        int pom = myArray[j];
        while (j > 0 && pom > myArray[j - 1])
        {
            myArray[j] = myArray[j - 1];
            j--;
            
        }
        myArray[j] = pom;
      }
         stopky1.Stop();
      
      
      Console.WriteLine("\n\n==============================================");
      Console.WriteLine("\n==============================================");
      Console.WriteLine("\nSeřazené pole (Insertion sort): ");
      for(int i=0;i<n;i++)
      Console.Write("{0}; ",myArray[i]);


    // Comb sort

    Stopwatch stopky2 = new Stopwatch();
    stopky2.Start();

    static int getNextGap(int gap){
        gap = (gap*10)/13;
        if (gap < 1)
            return 1;
        return gap;
    }
    static void combsort(int []myArray){
        int n = myArray.Length;
        int gap = n;
        bool swapped = true;

        while (gap != 1 || swapped == true){
            gap = getNextGap(gap);
            swapped = false;
        for (int i=0; i<n-gap; i++)
            {
                if (myArray[i] > myArray[i+gap])
                {
                    int temp = myArray[i];
                    myArray[i] = myArray[i+gap];
                    myArray[i+gap] = temp;
                    swapped = true;
            }
        }
    }
    }
    stopky2.Stop();
    

      Console.WriteLine("\n\n==============================================");
      Console.WriteLine("\nSeřazené pole (Comb sort): ");
      for(int i=0;i<n;i++)
      Console.Write("{0}; ",myArray[i]);

      Console.WriteLine("\n\n==============================================");
      Console.WriteLine("\n==============================================");
      Console.WriteLine("\nČas řazení (Insertion): {0}", stopky1.Elapsed);
      Console.WriteLine("\nČas řazení (Comb): {0}", stopky2.Elapsed);



    //Aritmetický průměr
    int soucet = 0;
    for (int i = 0; i < myArray.Length; i++)
        {
            soucet += myArray[i];
        }

        // Výpočet průměru
        int prumer = soucet / myArray.Length;
        int zbytek = soucet % myArray.Length;

        // Výpis výsledků
        Console.WriteLine("\n\n==============================================");
        Console.WriteLine("\nAritmetický průměr: {0}", prumer);
        Console.WriteLine("\nzbytek: {0}", zbytek);




        Console.WriteLine();
        Console.WriteLine("\n\nPro opakování programu napište A");
        again=Console.ReadLine();
}