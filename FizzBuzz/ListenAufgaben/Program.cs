using System;
using System.Collections.Generic;
using System.Linq;

namespace ListenAufgaben
{
    class Program
    {
        static void Main()
        {
            int i = 3;
            
            Staircase(i);

            Staircase(4);
        
        }
        private static void Lists3()
        {
            List<int> List3 = new List<int>() { 5, 4, 4, 3, -5, 5, 25, 25, 1, 9, 3, 0 };
            for (int i = 0; i < List3.Count; i++)
            {
                if (List3[i] == List3[i + 1])
                {
                    Console.WriteLine($"{List3[i]} ({i})");
                }
            }
            //Gib alle Zahlen und deren Position aus die zwei Mal direkt hintereinander vorkommen
            // Ergebnis
            // 4 (1)
            // 25 (6)

        }
        private static void Lists4()
        {
            List<int> List4 = new List<int>() { 3, -6, 4, 2, 2, 212, 3, 9, 212, 0, -50, 4, 3 };
            for (int i = 0; i < List4.Count; i++)
            {
                for (int u = 0; u < List4.Count; u++)
                {
                    if (List4[i] == List4[u++])
                    {
                        Console.WriteLine(List4[i]);
                    }
                }
                if (List4[i] == List4[i++])
                {
                    Console.WriteLine(List4[i]);
                }
            }
            // Gib alle Zahlen aus die doppelt vorkommen.
            // Ergebnis
            // 2
            // 212
            // 4
        }
        private static void Lists5()
        {
            
            List<int> List5 = new List<int>() { 0, 29, 59, 29, -30, 59, 29, 10 };
            int max = List5.Max();
            int counter = 0;
            //Console.WriteLine(max);
            for (int i = 0; i < List5.Count; i++)
            {
                if (max == List5[i])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            // Gib aus wie oft die höchste Zahl der Liste darin vorkommt
            // Ergebnis
            // 2
        }
        private static void Lists6()
        {
            List<int> listBob = new List<int>() { 3, 5, 9, 2, 12, 29 };
            List<int> listAlice = new List<int> { 2, 40, 50, -8, 12, 19 };
            int Bob = 0;
            int Alice = 0;

            for (int i = 0; i < listBob.Count; i++)
            {
                if (listBob[i] == listAlice[i])
                {
                    continue;
                }
                if (listBob[i] > listAlice[i])
                {
                    Bob++;
                }
                else
                {
                    Alice++;
                }


            }
            Console.WriteLine(Bob);
            Console.WriteLine(Alice);






            // Alice und Bob haben nach einer Spielerunde folgende Punktzahlen erzielt.
            // Die Position in jeder Liste gibt jeweils das gleiche Spiel an
            // d.h. listAlice[2] und listBob[2] geben jeweils die Punktzahl zu Spiel 3 an

            //List<int> listBob = new List<int>() { 3, 5, 9, 2, 12, 29 };
            //List<int> listAlice = new List<int> { 2, 40, 50, -8, 12, 19 };

            // Für jedes gewonnene Spiel, d.h. die höhere Punktzahl, bekommt der Spieler einen Punkt.
            // Bereche wer gewonnen hat und gib dies aus.
            // Ergebnis
            // Bob
        }
        public static void Staircase(int n)
        {
            // Gegeben ist die Höhe n einer Treppe
            // Gib eine Treppe bestehend aus Leerzeichen und #-Zeichen aus, die n-Stufen der Länge n hat.
            // Beispiel:
            // Eingabe: 4
            // Ausgabe:
            //     #
            //    ##
            //   ###
            //  ####
            Console.WriteLine((n*2).ToString());
        }
        public static void PlusMinus(List<int> arr)
        {
            // Gegeben ist eine Liste von ganzen Zahlen.
            // Gib aus welchen Anteil (auf 6 Nachkommastellen) positive, negative sowie Nullen einnehmen.
            // Beispiel
            // Eingabe:
            // -4 3 -9 0 4 1
            // Ausgabe:
            // 0.50000
            // 0.33333
            // 0.16667
            // Begründung:
            // 3 Positive -> 3/6
            // 2 Negative -> 2/6
            // 1 Null -> 1/6
        }
        public static List<int> GradingStudents(List<int> grades)
        {
            // Jeder Student erhält eine Note zwischen 0 und 100. Alles unter 50 bedeutet nicht bestanden.
            // Die Noten werden aber zuerstmal folgendermaßen gerundet:
            // Wenn die Differenz der Note und dem nächsten Vielfachen von 5 kleiner als 3 ist, wird auf das nächste Vielfache von 5 aufgerundet.
            // Wenn die Note kleiner 38 wird, wird nicht gerundet, da sowieso nicht bestanden ist.
            // Beispiel:
            // Eingabe:
            // 73, 67, 38, 33
            // Ausgabe:
            // 75, 67, 40, 33
            //throw new NotImplementedException();
            return grades;
        }
        static string TimeConversion(string s)
        {
            // Gegeben ist eine Uhrzeit in amerikanischer Notation. Ausgegeben werden soll die europäische Schreibweise.
            // Beispiele:
            // 08:50:45AM -> 08:50:45
            // 02:00:00PM -> 14:00:00
            // 12:00:00AM -> 00:00:00
            // 12:00:00PM -> 12:00:00
            return s;
        }

    }
}
