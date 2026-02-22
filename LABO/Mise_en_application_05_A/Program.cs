using System;
using System.Collections.Generic;

namespace RecursionExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Exercice 01 : PGCD ===");
            Console.WriteLine($"PGCD(48, 18) = {PGCD(48, 18)}");

            Console.WriteLine("\n=== Exercice 02 : Binaire ===");
            Console.Write("Dec2Bin(10) = ");
            Dec2Bin(10);
            Console.WriteLine();

            Console.WriteLine("\n=== Exercice 03 : Max Tableau ===");
            int[] tab = { 1, 5, 3, 9, 2 };
            Console.WriteLine($"MaxTab = {MaxTab(tab, tab.Length)}");

            Console.WriteLine("\n=== Exercice 04 : Palindrome ===");
            Console.WriteLine($"Palin('radar') = {Palin("radar")}");
            Console.WriteLine($"Palin('bonjour') = {Palin("bonjour")}");

            Console.WriteLine("\n=== Exercice 05 : Pascal ===");
            Console.WriteLine($"Pascal(2, 4) = {Pascal(2, 4)}");

            Console.WriteLine("\n=== Exercice 06 : Hanoï (3 disques) ===");
            Hanoi(3, "A", "C", "B");

            Console.WriteLine("\n=== Exercice 07 : Fibonacci ===");
            Console.WriteLine($"Fibonacci(7) = {Fibonacci(7)}");

            Console.WriteLine("\n=== Exercice 08 : Somme Chiffres ===");
            Console.WriteLine($"SumDigits(1234) = {SumDigits(1234)}");

            Console.WriteLine("\n=== Exercice 09 : Puissance ===");
            Console.WriteLine($"Power(2, 5) = {Power(2, 5)}");

            Console.WriteLine("\n=== Exercice 10 : Multiplication ===");
            Console.WriteLine($"Multiply(4, 3) = {Multiply(4, 3)}");

            Console.WriteLine("\n=== Exercice 11 : Inverse Chaîne ===");
            Console.WriteLine($"ReverseStr('chat') = {ReverseStr("chat")}");

            Console.WriteLine("\n=== Exercice 12 : Compter Caractère ===");
            Console.WriteLine($"CountChar('programmation', 'o') = {CountChar("programmation", 'o')}");

            Console.WriteLine("\n=== Exercice 13 : Somme Tableau ===");
            Console.WriteLine($"SumArray([1,2,3,4,5]) = {SumArray(new int[] { 1, 2, 3, 4, 5 }, 5)}");

            Console.WriteLine("\n=== Exercice 14 : Permutations ===");
            var perms = Permute("abc");
            Console.WriteLine($"Permute('abc') : [{string.Join(", ", perms)}]");

            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }

        // --- EXERCICE 01 ---
        public static int PGCD(int n, int m)
        {
            if (m == 0) return n;
            return PGCD(m, n % m);
        }

        // --- EXERCICE 02 ---
        public static void Dec2Bin(int n)
        {
            if (n > 1) Dec2Bin(n / 2);
            Console.Write(n % 2);
        }

        // --- EXERCICE 03 ---
        public static int MaxTab(int[] tab, int n)
        {
            if (n == 1) return tab[0];
            return Math.Max(tab[n - 1], MaxTab(tab, n - 1));
        }

        // --- EXERCICE 04 ---
        public static bool Palin(string mot)
        {
            return PalinHelper(mot, 0, mot.Length - 1);
        }
        private static bool PalinHelper(string mot, int start, int end)
        {
            if (start >= end) return true;
            if (mot[start] != mot[end]) return false;
            return PalinHelper(mot, start + 1, end - 1);
        }

        // --- EXERCICE 05 ---
        public static int Pascal(int col, int lin)
        {
            if (col == 0 || col == lin) return 1;
            return Pascal(col - 1, lin - 1) + Pascal(col, lin - 1);
        }

        // --- EXERCICE 06 ---
        public static void Hanoi(int n, string source, string destination, string auxiliaire)
        {
            if (n == 1)
            {
                Console.WriteLine($"Déplacer disque 1 de {source} vers {destination}");
                return;
            }
            Hanoi(n - 1, source, auxiliaire, destination);
            Console.WriteLine($"Déplacer disque {n} de {source} vers {destination}");
            Hanoi(n - 1, auxiliaire, destination, source);
        }

        // --- EXERCICE 07 ---
        public static int Fibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        // --- EXERCICE 08 ---
        public static int SumDigits(int n)
        {
            if (n == 0) return 0;
            return (n % 10) + SumDigits(n / 10);
        }

        // --- EXERCICE 09 ---
        public static int Power(int baseVal, int exposant)
        {
            if (exposant == 0) return 1;
            if (exposant % 2 == 0)
            {
                int half = Power(baseVal, exposant / 2);
                return half * half;
            }
            else
            {
                return baseVal * Power(baseVal, exposant - 1);
            }
        }

        // --- EXERCICE 10 ---
        public static int Multiply(int a, int b)
        {
            if (b == 0) return 0;
            return a + Multiply(a, b - 1);
        }

        // --- EXERCICE 11 ---
        public static string ReverseStr(string mot)
        {
            if (string.IsNullOrEmpty(mot)) return "";
            return ReverseStr(mot.Substring(1)) + mot[0];
        }

        // --- EXERCICE 12 ---
        public static int CountChar(string mot, char c)
        {
            if (string.IsNullOrEmpty(mot)) return 0;
            int count = (mot[0] == c) ? 1 : 0;
            return count + CountChar(mot.Substring(1), c);
        }

        // --- EXERCICE 13 ---
        public static int SumArray(int[] tab, int n)
        {
            if (n == 0) return 0;
            return tab[n - 1] + SumArray(tab, n - 1);
        }

        // --- EXERCICE 14 ---
        public static List<string> Permute(string mot)
        {
            List<string> result = new List<string>();
            if (mot.Length == 1)
            {
                result.Add(mot);
                return result;
            }

            char first = mot[0];
            string rest = mot.Substring(1);
            List<string> subPerms = Permute(rest);

            foreach (string sub in subPerms)
            {
                for (int i = 0; i <= sub.Length; i++)
                {
                    string newPerm = sub.Insert(i, first.ToString());
                    result.Add(newPerm);
                }
            }
            return result;
        }
    }
}