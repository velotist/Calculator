using System;

namespace Calculator
{
    class Calculator
    {
        public void Run()
        {
            // Beginn einer Endlosschleife
            while(true)
            {
                double number1, number2, result;
                char operation;
                // Startbedingungen für die Berechnung
                // wenn die Methoden NumberInput() und OperationInput() ein true zurücklieferten, dann wird
                // der Anweisungsblock in switch/case abgearbeitet
                // die zweimalige logische Und-Verknüpfung mit der Methode NumberInput deshalb, weil wir sie für
                // die Eingabe der ersten und der zweiten Zahl aufrufen
                if (NumberInput(out number1) && OperationInput(out operation) && NumberInput(out number2))
                {
                    // we do calculation
                    switch(operation)
                    {
                        case '+':
                            result = number1 + number2;
                            break;
                        case '-':
                            result = number1 - number2;
                            break;
                        case '*':
                            result = number1 * number2;
                            break;
                        case '/':
                            result = number1 / number2;
                            break;
                        case '%':
                            result = number1 % number2;
                            break;
                        default:
                            // wir benötigen hier eine Zuweisung für die result-Variable, da der Compiler sonst
                            // eine Fehlermeldung ausgibt, dass er eine Zuweisung braucht
                            result = 0.0;
                            break;
                    }
                    Console.WriteLine("Ergebnis       {0}",result);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Bye bye");
                    break;
                }
            }
        }

        // die Methode für die Überprüfung einer korrekten Eingaben; bei Korrektheit
        // der Eingabe wird true zurückgeliefert
        private bool NumberInput(out double number)
        {
            // Beginn einer Endlosschleife; diese wird durch die Eingabe des Zeichens q beendet
            while(true)
            {
                // Abfrage der Nutzereingabe
                Console.Write("Zahl           ");
                string input = Console.ReadLine();
                // wenn ein q eingegeben wurde, dann liefert die Methode false zurück
                // q steht hier für quit und beendet das Programm, da in der Methode Run()
                // die logische Und-Verknüpfung nicht mehr erfüllt ist und das Programm
                // aus der Endlosschleife in Run() aussteigt
                if (input.Equals("q"))
                {
                    number = 0.0;
                    return false;
                }
                if (double.TryParse(input, out number))
                {
                    break;
                }
                // bei einer Fehleingabe wird eine lesbare Fehlerrückmeldung an den Nutzer erzeugt
                else
                {
                    Console.WriteLine("Die Eingabe war fehlerhaft. Versuchen Sie es nochmal. Hier bitte nur Zahlen eingeben.");
                }
            }
            // wenn alles passt, gib einen true Wert zurück
            return true;
        }

        // die Methode für die Prüfung der korrekten Eingabe der Operatoren
        private bool OperationInput(out char operation)
        {
            string operationen = "+-*/%";
            // Beginn einer Endlosschleife
            while(true)
            {
                Console.Write("Operator        ");
                string input = Console.ReadLine();
                if (input.Equals("q"))
                {
                    operation = '0';
                    return false;
                }
                // wenn die Länge der Eingabe = eins ist (damit wird die Eingabe von zwei oder mehr Operatoren
                // abgefangen) und der Operator ein Zeichen des Strings enthält
                // dann weise der Variablen den passenden Operator zu
                if (input.Length == 1 && operationen.Contains(input))
                {
                    operation = input[0];
                    break;
                }
                // ansonsten gib eine lesbare Fehlermeldung an den Nutzer aus
                else
                {
                    Console.WriteLine("Die Eingabe war fehlerhaft. Versuchen Sie es nochmal. Wählen Sie bitte zwischen +, -, *, / und %.");
                }
            }
            // wenn alles passt gib true zurück für die Abarbeitung der Run()-Methode
            return true;
        }
    }
}

