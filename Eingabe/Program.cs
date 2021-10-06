using System;

namespace Eingabe
{
    class Program
    {
        static void Main(string[] args)
        {
            string lesen = "";

            // Auslesen einer Zeile in der Konsole
            // In C:
            // scanf("%i", &variable);
            lesen = Console.ReadLine();

            // Auslesen des nächsten characters im lese-buffer
            int zahl = Console.Read();

            Console.WriteLine(lesen);
            Console.WriteLine(zahl);
        }
    }
}
