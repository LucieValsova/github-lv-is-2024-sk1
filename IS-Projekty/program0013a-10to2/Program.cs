using System;
using System.Data;
using System.Net.Security;

class Program {
    static void Main() {
        
        string again = "a";
        
        while(again == "a") {
            Console.WriteLine("*********************************");
            Console.WriteLine("*** Převod z 10 do 2 soustavy ***");
            Console.WriteLine("*********************************");
            Console.WriteLine("********* Lucie Valsová *********");
            Console.WriteLine("*********************************");
            Console.WriteLine();

            Console.Write("Zadejte číslo v desítkové soustavě (přirozené číslo):");
            uint n;
            while(!uint.TryParse(Console.ReadLine(), out n)) {
                Console.WriteLine("Nezadali jste přirozené číslo, Zadejte číslo znovu: ");
            }

            uint[] myArray = new uint[32];
            uint zaloha = cislo;
            uint zbytek;

            for (i = 0; cislo > 0; i++){
                zbytek = cislo % 2;
                cislo = (cislo - zbytek)/2;
                myArray[i] = zbytek;

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Celá část = {0} \nZbytek = {1}", cislo, zbytek);
            }

            Console.WriteLine("\nPoslední využitá buňka pole: {0}," i-1);

            Console.BackgroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\nVýsledek:");
            for (uint j = i - 1; j >= 0; j++){
                Console.Write("{0}", myArray[j]);
            }
            


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();

        }
    }
}