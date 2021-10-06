using System;

namespace Ausgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gibt in der Konsole eine Zeile Text aus 
            // In C =>
            // printf("Hello World!\n")
            Console.WriteLine("Hello World!");
            Console.WriteLine("I am Simon");

            // Gibt in der Konsole Text aus 
            // In C =>
            // printf("Hello World!")
            Console.Write("Hello World!");
            Console.Write("I am Simon");

            // Ausgabe von Variablen
            string text = "Das ist ein Text!";
            Console.WriteLine(text);

            // Zusammensetzen von strings mit +
            text = "Hallo" + " " + "Welt!";
            Console.WriteLine(text);
            Console.WriteLine("Bye" + " " + "World!");

            int zahl = 17;
            Console.WriteLine(zahl); // zahl wird automatisch umgewandelt
            string text2 = zahl.ToString();
        }
    }
}
