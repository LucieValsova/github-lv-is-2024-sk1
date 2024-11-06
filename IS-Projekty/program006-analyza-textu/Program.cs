string again = "a";
while(again == "a") {
            Console.WriteLine("*******************************************");
            Console.WriteLine("************** Analýza textu **************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*************** Lucie Valsová *************");
            Console.WriteLine("*******************************************");
            Console.WriteLine();

            Console.Write("Zadejte váš text: ");
            string myText = Console.ReadLine();
            
            Console.WriteLine();
            Console.WriteLine("\nVáš text: {0}", myText);
            Console.WriteLine("\nDělka vašeho textu je {0} znaků", myText.Length);

            string samohlasky = "aáeéěiíoóuůúyý";
            string souhlasky = "qwrtpsdfghjklxcvbnm";
            string cislice = "0123456789";

            int pSamohlasek = 0;
            int pSouhlasek = 0;
            int pCislic = 0;
            int pOstatnich = 0;

            foreach(char znak in myText) {
                if(samohlasky.Contains(znak)) {
                    pSamohlasek++;
                }
                else if(souhlasky.Contains(znak)) {
                    pSouhlasek++;
                }
                else if(cislice.Contains(znak)) {
                    pCislic++;
                } 
                else 
                    pOstatnich++; 
            }

            Console.WriteLine("\n\nPočet samohlásek = {0}", pSamohlasek);
            Console.WriteLine("Počet souhlásek = {0}", pSouhlasek);
            Console.WriteLine("Počet číslic = {0}", pCislic);
            Console.WriteLine("Počet ostatních znaků = {0}", pOstatnich);

        
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu napište A");
            again=Console.ReadLine();
    }