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
         int numberBackup = number;
        
        string numberStr = number.ToString();
        char[] digits = numberStr.ToCharArray();
        int suma = 0;
        foreach (char digit in digits)
        {
        suma += int.Parse(digit.ToString());
        }

       Console.WriteLine("Číslo = {0}", number);
       //musíme přičíst ještě poslední cifru
       Console.WriteLine();
       Console.WriteLine("\nSoučet cifer čísla {0} je {1}", numberBackup, suma);
        
        
        Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();
}
