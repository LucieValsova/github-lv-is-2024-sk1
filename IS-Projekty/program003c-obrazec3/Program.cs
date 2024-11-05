using System.Globalization;
using System.Security.Cryptography;

string again = "a";

while (again == "a")
{

    Console.Clear();
    Console.WriteLine("***********************************");
    Console.WriteLine("******Výkres obrazce diamantu******");
    Console.WriteLine("***********************************");
    Console.WriteLine("********* Lucie Valsová ***********");
    Console.WriteLine("***********************************");
    Console.WriteLine();

    Console.Write("Zadejte velikost strany obrazce (celé číslo): ");
    int strana;
    while (!int.TryParse(Console.ReadLine(), out strana))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte velikost strany znovu: ");
    }

    int mid = strana / 2;

    for (int i = 0; i < strana; i++)
    {
        int spaces = Math.Abs(mid - i);
        int stars = strana - 2 * spaces;

        Console.Write(new string(' ', spaces));
        Console.WriteLine(new string('*', stars));
    }

    Console.ReadLine();
// zpoždění
System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(50));

Console.WriteLine();
        }   
            
            Console.WriteLine();
Console.WriteLine("Pro opakování programu stiskněte klávesu A");
again = Console.ReadLine();