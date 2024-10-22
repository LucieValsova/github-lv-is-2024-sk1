using System.Globalization;

string again = "a";

        while(again == "a") {

            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("***** Výpis řady čísel *****");
            Console.WriteLine("****************************");
            Console.WriteLine("****** Lucie Valsová *******");
            Console.WriteLine("****************************");
            Console.WriteLine();

            Console.Write("Zadejte stranu obrazce (celé číslo): ");
            int strana;
            while(!int.TryParse(Console.ReadLine(), out strana)) {
                Console.Write("Nezadali jste celé číslo. Zadejte stranu šířku: ");
            }

            for(int i=1; i<= strana; i++) {
                for(int j=1; j<= strana-i; j++) {}
                for(int k=1; k<= i; k++){
                    Console.Write("* ");   
                    // zpoždění
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(50));
                
                }
                Console.WriteLine();
            }
            
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();
        }