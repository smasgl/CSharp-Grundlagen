using System;

namespace Datentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ganzzahl
            int zahl = 5;
            // Kommazahl
            double kommaZahl = 0.0;
            float kommaZahl2 = 0;
            // Text
            string text = "Hallo";
            // Charakter
            char charakter = 'A';

            // Umwandlung von Datentypen

            // Von Zahl zu String
            string umwandlung = zahl.ToString();
            string umwandlung2 = kommaZahl.ToString();

            // Von String zu Ganz-Zahl
            zahl = Convert.ToInt32(umwandlung);
            zahl = int.Parse(umwandlung); // Ohne abfangen von Fehlern
            if(!int.TryParse(umwandlung, out int zahl2)) // Mit abfangen von Fehlern
            {
                // Umwandlung hat nicht funktioniert
            }
            // Das Ergebnis bei einer Erfolgreichen Umwandlung steht in der angegebenen Variable
            // => zahl2

            // Von String zu Komma-Zahl
            kommaZahl = double.Parse(umwandlung2);

            try
            {
                string schlechteZahl = "123a";
                int ergebnis = Convert.ToInt32(schlechteZahl);
            }
            catch
            {
                // Wenn im Try-Block ein Fehler passiert
                Console.WriteLine("Convertierung war fehlerhaft!");
            }

            // Wenn kein Fehler passiert wird der Catch-Block nicht aufgerufen
        }
    }
}
