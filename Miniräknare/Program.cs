using System;
using System.Collections.Generic;
using System.Linq;
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

            // Användaren ombeds att ange en operation (+, -, *, /)
            Console.WriteLine("Ange operation (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar; // Läs in operation från användaren
            Console.WriteLine("\nAnge första talet: ");
            double num1 = Convert.ToDouble(Console.ReadLine()); // Läs in första talet
            Console.WriteLine("Ange andra talet: ");
            double num2 = Convert.ToDouble(Console.ReadLine()); // Läs in andra talet

            // Variabel som lagrar resultatet av operationen
            double result = 0;

            // Switch-sats för att hantera olika valen som användare kan göra i programmet
            switch (operation)
            {
                case '+':
                    result = num1 + num2; // Addition
                    break;
                case '-':
                    result = num1 - num2; // Subtraktion
                    break;
                case '*':
                    result = num1 * num2; // Multiplikation
                    break;
                case '/':
                    // Kontroll för att undvika division med noll
                    if (num2 != 0)
                    {
                        result = num1 / num2; // Division
                    }
                    else
                    {
                        // Felmeddelande om användaren försöker dividera med noll
                        Console.WriteLine("Fel: Division med noll är inte tillåten.");
                        return;
                    }
                    break;
                default:
                    // Om användaren anger en ogiltig operation
                    Console.WriteLine("Ogiltig operation.");
                    return;
            }

            // Visar resultatet av operationen för användaren
            Console.WriteLine($"Resultat: {result}");
            Console.ReadKey(); // Väntar på att användaren trycker på en tangent innan programmet avslutas
        }
    }
}
