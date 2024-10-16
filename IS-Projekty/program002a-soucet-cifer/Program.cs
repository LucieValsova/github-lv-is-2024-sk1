 string again = "a";
        
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("***** Výpis řady čísel *****");
            Console.WriteLine("****************************");
            Console.WriteLine("****** Lucie Valsová *******");
            Console.WriteLine("****************************");
            Console.WriteLine();
            
         Console.Write("Zadejte celé číslo: ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
            }
       
       int suma = 0;
       int soucin = 1;
       int numberBackup = number;
       int digit;

       while(number >= 10) {
        digit = number % 10;
        number = (number-digit)/10;
        Console.WriteLine("Číslo = {0}", digit);
        suma = suma + digit;
        soucin = soucin * digit;
       }
       Console.WriteLine("Číslo = {0}", number);

       //musíme přičíst ještě poslední cifru
       suma = suma + number;
       soucin = soucin * number;

       Console.WriteLine();
       Console.WriteLine("\nSoučet cifer čísla {0} je {1}", numberBackup, suma);
       Console.WriteLine("\nSoučin cifer čísla {0} je {1}", numberBackup, soucin);
        
        
        Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();
}