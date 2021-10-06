using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erstellen eines Arrays
            // In C:
            // int myArray[255];
            // Deklaration
            int[] myArray;

            // Zuweisen von Werten
            // Initialisierung
            myArray = new int[255];
            int[] myArray2 = { 0, 1 };

            for (int i = 0; i < myArray.Length; i++) // Mit .Length anzahl an Feldern auslesen
            {
                // Zugriff auf Feld
                Console.WriteLine(myArray[i]);
            }

            // Zuweisen von Werten
            myArray2[0] = 1;
            myArray2[1] = 2;

            // Index out of Range => Dieser Bereich auf den man zugreift existiert nicht
            // In C:
            // Kein Fehler => Wird eine Zufällige Zahl zurückgeben
            // myArray2[5] = 2;
        }
    }
}
