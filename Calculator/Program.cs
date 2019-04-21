using System;

/*  Author:     Konstantin Golovnenkov && Marcus Greiner
 *  
 *  Version:    1.0
 *  Date:      08.03.2019
 *  
 *  A little calculator in the console for operations in additon, subtraction,
 *  multiplication, division and modulo of two double or int numbers.
 *  
 */

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc1 = new Calculator();
            Console.WriteLine("Konsolen-Taschenrechner");
            Console.WriteLine("Sie werden nach der ersten Zahl gefragt.");
            Console.WriteLine("Anschließend können Sie einen der folgenden Operatoren wählen:");
            Console.WriteLine();
            Console.WriteLine("                 +    -   *   /   %");
            Console.WriteLine();
            Console.WriteLine("Wollen Sie beginnen? Jederzeit q fürs Beenden.");
            Console.Write("Press key... ");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Okay. Bitte erste Zahl eingeben, mit Enter bestätigen, danach den Operator und dann die zweite Zahl.");
            Console.WriteLine("Fürs Beenden könne Sie jederzeit die Taste q betätigen.");
            Console.WriteLine();
            calc1.Run();
        }
    }
}
