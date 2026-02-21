using System.Collections;
using System.Collections.Generic;


namespace collections_in_csharp.Collections
{

    /// <summary>
    /// Les collections génériques fonctionnent sur un type spécifique, 
    /// tandis que les collections non génériques fonctionnent sur le type « Object »
    /// </summary>
    public class GenericsCollections
    {
        public static void UsingList()
        {
            List<int> numbers = new List<int>();

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            foreach (int nbr in numbers)
            {
                Console.WriteLine(nbr);
            }
        }


        public static void UsingDictionary()
        {
            Dictionary<int, string> languages = new Dictionary<int, string>();

            languages.Add(5, "Java");
            languages.Add(2, "Python");
            languages.Add(3, "C#");
            languages.Add(1, "C++");
            languages.Add(10, "SQL");

            foreach ( KeyValuePair<int, string> language in languages)
            {
                Console.WriteLine("Clé: {0}, Valeur: {1}", language.Key, language.Value);
            }

            // Trier par clé 
            Console.WriteLine("Trier par clé");
            Console.WriteLine("=============");
            foreach (KeyValuePair<int, string> langage in languages.OrderBy(key => key.Key))
            {
                Console.WriteLine("Clé: {0}, Valeur: {1}", langage.Key, langage.Value);
            }
            Console.WriteLine("=============");
            // Trier par valeur
            Console.WriteLine("Trier par valeur");
            Console.WriteLine("=============");
            foreach (KeyValuePair<int, string> langage in languages.OrderBy(key => key.Value))
            {
                Console.WriteLine("Clé: {0}, Valeur: {1}", langage.Key, langage.Value);
            }
        }

        public static void UsingStack()
        {
            Stack<string> languages = new Stack<string>();

            languages.Push("Java");
            languages.Push("C#");
            languages.Push("Python");
            languages.Push("C++");

            foreach (string o in languages)
            {
                Console.WriteLine(o);
            }
        }

        public static void UsingQueue()
        {
            Queue<string> languages = new Queue<string>();

            languages.Enqueue("Java");
            languages.Enqueue("C#");
            languages.Enqueue("Python");
            languages.Enqueue("C++");

            foreach (string o in languages)
            {
                Console.WriteLine(o);
            }
        }
    }
  
}
