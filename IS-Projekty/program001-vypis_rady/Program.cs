﻿using System;
using System.Data;

class Program {
    static void Main() {
        
        string again = "a";
        
        while(again == "a") {
            Console.WriteLine("****************************");
            Console.WriteLine("***** Výpis řady čísel *****");
            Console.WriteLine("****************************");
            Console.WriteLine("****** Lucie Valsová *******");
            Console.WriteLine("****************************");
            Console.WriteLine();

            // Vstup hodnot do programu - špatně řešený
            // Console.Write("Zadejte první číslo řady: ");
            // int first = int.Parse(Console.ReadLine());

            // Vstup hodnot do programu - správně řešený
            Console.Write("Zadejte první číslo řady (celé číslo): ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first)) {
                Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
            }

            Console.Write("Zadejte poslední číslo řady (celé číslo): ");
            int last;
            while(!int.TryParse(Console.ReadLine(), out last)) {
                Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo řady znovu: ");
            }

            Console.Write("Zadejte diferenci (celé číslo): ");
            int step;
            while(!int.TryParse(Console.ReadLine(), out step)) {
                Console.Write("Nezadali jste celé číslo. Zadejte diference znovu: ");
            }

            // Výpis zadaných hodnot
            Console.WriteLine();
            Console.WriteLine("Zadali jste tyto hodnoty: ");
            Console.WriteLine("První číslo řady: {0}", first);
            Console.WriteLine("Poslední číslo řady: {0}", last);
            Console.WriteLine("Diference: {0}", step);

            // Výpis řady
            Console.WriteLine();
            Console.WriteLine("==================");
            Console.WriteLine("Výpis číselné řady");
            int current = first;
            while(current <= last) {
                Console.WriteLine(current);
                current = current + step; // Ruční přičtení diference
            }    

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
