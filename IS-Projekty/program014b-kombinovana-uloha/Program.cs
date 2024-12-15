using System.Diagnostics;
using System.Globalization;
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
      
      for(int i=0;i<n;i++)
      {
        myArray[i]=myArray[i] = randomNumber.Next(dm, hm+1);
        Console.Write("");
      }
      

      // Bubble sort
      for(int i=0;i<n-1;i++)
        for(int j=0;j<n-i-1;j++)
          if(myArray[j]<myArray[j+1])
          {
            int pom = myArray[j+1];
            myArray[j+1] = myArray[j];
            myArray[j] = pom;
            //pocetVymenB++;
          }
      
      Console.WriteLine("\n\n==============================================");
      Console.WriteLine("\n\nSeřazené pole (Bubble sort): ");
      for(int i=0;i<n;i++)
        Console.Write("{0}; ",myArray[i]);
      
      // Insertion sort
      Console.WriteLine("");
      for(int i=0;i<n;i++)
        Console.Write("");

      
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
      
      
      Console.WriteLine("\n\n==============================================");
      Console.WriteLine("\n\nSeřazené pole (Insertion sort): ");
      
      for(int i=0;i<n;i++)
        Console.Write("{0}; ",myArray[i]);


      //Shaker sort//
      for (int i = 0; i < myArray.Length / 2; i++){
            bool swapped = false; 
            for (int j = i; j < myArray.Length - i - 1; j++){
                if (myArray[j] < myArray[j + 1]) {
                int tmp = myArray[j];
                myArray[j] = myArray[j + 1];
                myArray[j + 1] = tmp;
                swapped = true; 
                }
            }
            for (int j = myArray.Length - 2 - i; j > i; j--){
                if (myArray[j] > myArray[j - 1]){
                int tmp = myArray[j];
                myArray[j] = myArray[j - 1];
                myArray[j - 1] = tmp;
                swapped = true;
                }
            }
            if (!swapped) break;
        }
        
      
     Console.WriteLine("\n\n==============================================");
     Console.WriteLine("\n\nSeřazené pole (Shaker sort): ");
      
      for(int j=0;j<n;j++)
        Console.Write("{0}; ",myArray[j]);


        //druhé největší číslo
        int secondLargest = int.MinValue;
        int thirdLargest = int.MinValue;
        int fourthLargest = int.MinValue;

        for (int i = 1; i < n; i++)
        {
            if (myArray[i] > max)
            {
                secondLargest = max;  // Aktualizujeme druhé největší číslo
                max = myArray[i];            // Nastavíme nové největší číslo
            }
            else if (myArray[i] > secondLargest && myArray[i] < max)
            {
                secondLargest = myArray[i];     // Nastavíme nové druhé největší číslo
            }
            else if (myArray[i] > thirdLargest && myArray[i] < secondLargest)
            {
                thirdLargest = myArray[i];    
            }
            else if (myArray[i] > fourthLargest && myArray[i] < thirdLargest)
            {
                fourthLargest = myArray[i];    
            }
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n\n==============================================");
        Console.WriteLine("\nDruhé největší číslo: {0};", secondLargest);
        Console.WriteLine("\nTřetí největší číslo: {0};", thirdLargest);
        Console.WriteLine("\nČtvrté největší číslo: {0};", fourthLargest);

        //Medián
        int median = max / 2;

        Console.WriteLine("\n\n==============================================");
        Console.WriteLine("\nMedián: {0}", median);
                
        //Binarní
        int number = fourthLargest;
        string Result = string.Empty;
            for (int i = 0; number > 0; i++)
            {
                Result = number % 2 + Result;
                number = number / 2;
            }
            
            Console.WriteLine("\n\n==============================================");
            Console.WriteLine("\nČtvrté největší číslo převedené do dvojkové soustavy: {0} = {1}",fourthLargest, Result);

        //Obrazce
        Console.WriteLine("\n\n==============================================");
        Console.WriteLine("\nObrazec výška = medián {0}; šířka = třetí největší číslo {1}\n",median, thirdLargest);

        int height = median;
        int width = thirdLargest;

        // První dva řádky
            for (int i = 1; i <= 2; i++){
                    Console.Write("    ");
            for (int j = 1; j <= width - 4; j++){
                    Console.Write("* ");
            }
                Console.WriteLine();
            }

        // Střední část obrazce (všechno s plnými hvězdičkami)
        for (int i = 3; i <= height; i++) {
        for (int j = 1; j <= width; j++){
                Console.Write("* ");
        }
            Console.WriteLine();
        }

        // Poslední dva řádky
        for (int i = 1; i <= 2; i++){
                Console.Write("    ");
        for (int j = 1; j <= width-4; j++){
                Console.Write("* ");
            }
            Console.WriteLine();
        }


        

        


        Console.WriteLine();
        Console.WriteLine("\n\nPro opakování programu napište A");
        again=Console.ReadLine();
}