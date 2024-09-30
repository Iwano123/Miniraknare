using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Miniräknare
{
    class Program
    {
        static void Main(string[] args)
        {
            // Välkomstmeddelande
            Console.WriteLine("Enkel Kalkylator");

            bool continueCalculating = true; // Flagga för att avgöra om programmet ska fortsätta eller avslutas

            while (continueCalculating)
            {
                // Visar menyval för användaren
                Console.WriteLine("\n*** Enkel Kalkylator ***");
                Console.WriteLine("Välj en operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraktion (-)");
                Console.WriteLine("3. Multiplikation (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Avsluta programmet");
                Console.Write("Ange ditt val (1-5): ");
                char choice = Console.ReadKey().KeyChar; // Läser in användarens val
                Console.WriteLine(); // Ny rad för att separera användarens val från nästa utmatning

                if (choice == '5') // Om användaren väljer att avsluta
                {
                    continueCalculating = false; // Avslutar loopen och programmet
                    break;
                }

                // Läs in de två talen
                Console.WriteLine("\nAnge första talet: ");
                double num1 = Convert.ToDouble(Console.ReadLine()); // Läs in första talet
                Console.WriteLine("Ange andra talet: ");
                double num2 = Convert.ToDouble(Console.ReadLine()); // Läs in andra talet

                // Variabel som lagrar resultatet av operationen
                double result = 0;

                // Switch-sats för att hantera olika valen som användare kan göra i programmet
                switch (choice)
                {
                    case '1':
                        result = num1 + num2; // Addition
                        break;
                    case '2':
                        result = num1 - num2; // Subtraktion
                        break;
                    case '3':
                        result = num1 * num2; // Multiplikation
                        break;
                    case '4':
                        // Kontroll för att undvika division med noll
                        if (num2 != 0)
                        {
                            result = num1 / num2; // Division
                        }
                        else
                        {
                            // Felmeddelande om användaren försöker dividera med noll
                            Console.WriteLine("Fel: Division med noll är inte tillåten.");
                            continue;
                        }
                        break;
                    default:
                        // Om användaren anger en ogiltig operation
                        Console.WriteLine("Ogiltig operation.");
                        continue;
                }

                // Visar resultatet av operationen för användaren
                Console.WriteLine($"Resultat: {result}");
                Console.WriteLine("\nVill du göra en ny beräkning? (j/n): ");
                char continueChoice = Console.ReadKey().KeyChar;
                if (continueChoice != 'j' && continueChoice != 'J')
                {
                    continueCalculating = false; // Avslutar programmet om användaren väljer något annat än 'j'
                }
            }

            // Avslutar programmet
            Console.WriteLine("\nTack för att du använde kalkylatorn! Programmet avslutas.");
        }
    }
}
