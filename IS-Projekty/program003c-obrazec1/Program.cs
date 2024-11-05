using System.Globalization;

string again = "a";

        while(again == "a") {

            Console.Clear();
            Console.WriteLine("***********************************");
            Console.WriteLine("***** Výkres obrazce diamantu *****");
            Console.WriteLine("***********************************");
            Console.WriteLine("********* Lucie Valsová ***********");
            Console.WriteLine("***********************************");
            Console.WriteLine();

            Console.Write("Zadejte velikost strany obrazce (celé číslo): ");
            int strana;
            while(!int.TryParse(Console.ReadLine(), out strana)) {
                Console.Write("Nezadali jste celé číslo. Zadejte velikost strany znovu: ");
            }

        int z = 1;

        for (int i = 0; i <= strana; i++){   
            for (int j = strana; j > i; j--){
                Console.Write(" ");
            }
                Console.Write("*");
            if (i > 0){
            for (int k = 1; k <= z; k++)
                {Console.Write(" ");}
                z += 2;
                Console.Write("*");
            }
            Console.WriteLine();
        }

        z -= 4;

        for (int i = 0; i <= strana - 1; i++){
            for (int j = 0; j <= i; j++){
                Console.Write(" ");
            }
            Console.Write("*");
            for (int k = 1; k <= z; k++){
                Console.Write(" ");
            }

        z -= 2;
        
        if (i != strana - 1){
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadLine();   
                    // zpoždění
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(50));
                
                Console.WriteLine();
            }
            
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();