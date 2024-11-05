using System.Globalization;

string again = "a";

while (again == "a")
{

    Console.Clear();
    Console.WriteLine("**********************");
    Console.WriteLine("***Výkres obrazce N***");
    Console.WriteLine("**********************");
    Console.WriteLine("***Lucie Valsová******");
    Console.WriteLine("**********************");
    Console.WriteLine();

    Console.Write("Zadejte velikost strany obrazce (celé číslo): ");
    int strana;
    while (!int.TryParse(Console.ReadLine(), out strana))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte velikost strany znovu: ");
    }

    for (int i = 0; i < strana; i++)
    {
        for (int j = 0; j < strana; j++)
        {
            if (j == 0  ||j == strana - 1||  i == j)
                Console.Write("*");
            else
                Console.Write(" ");
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