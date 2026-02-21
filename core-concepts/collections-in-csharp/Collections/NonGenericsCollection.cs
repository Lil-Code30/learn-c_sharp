
using System.Collections;

namespace collections_in_csharp.Collections
{
    public class NonGenericsCollection
    {
        /// <summary>
        /// La classe ArrayList est une collection qui peut être utilisée pour tout type ou objet. 
        /// Arraylist est une classe similaire à un tableau, mais elle peut être utilisée pour stocker des valeurs de différents types.
        /// Un Arraylist n’a pas de taille spécifique.N’importe quel nombre d’éléments peut être stocké.
        /// </summary>
        public static void UsingArrayList()
        {
            ArrayList numbers = new ArrayList();

            numbers.Add(1);
            numbers.Add(1.967);
            numbers.Add("one");
            numbers.Add('o');

            foreach (object nbr in numbers)
            {
                Console.WriteLine($"{nbr}");
            }
        }

        /// <summary>
        /// HashTable est similaire à arraylist, mais représente les éléments sous forme de clé et valeur.
        /// </summary>
        public static void UsingHashTable()
        {
            Hashtable languages = new Hashtable();

            languages.Add(1, "Java");
            languages.Add(2, "C#");
            languages.Add(3, "Python");
            languages.Add(4, "C++");

            foreach (DictionaryEntry language in languages)
            {
                Console.WriteLine("Clé: {0}, Valeur: {1}", language.Key, language.Value);
            }
        }

        /// <summary>
        /// La classe SortedList est une classe qui combine l’arraylist et hashtable, ainsi représente les données sous forme de paire clé/valeur, 
        /// et organise tous les éléments dans un ordre trié.
        /// </summary>
        public static void UsingStortedList()
        {
            SortedList languages = new SortedList();

            languages.Add(1, "Java");
            languages.Add(2, "C#");
            languages.Add(3, "Python");
            languages.Add(4, "C++");

            foreach (DictionaryEntry language in languages)
            {
                Console.WriteLine("Clé: {0}, Valeur: {1}", language.Key, language.Value);
            }
        }

        /// <summary>
        /// Il représente une collection d’objets LIFO(Last In First Out). 
        /// Lorsque vous ajoutez un élément dans la liste, cela s’appelle PUSH ou Empiler et 
        /// lorsque vous le supprimez, cela s’appelle POP ou Dépiler.
        /// </summary>
        public static void UsingStack()
        {
            Stack languages = new Stack();

            languages.Push("Java");
            languages.Push("C#");
            languages.Push("Python");
            languages.Push("C++");

            foreach (object o in languages)
            {
                Console.WriteLine(o);
            }
        }

        /// <summary>
        /// Il représente une collection d’objets FIFO(First In First Out). 
        /// Lorsque vous ajoutez un élément à la liste, cela s’appelle « Enqueue »
        /// ou « Enfiler » et lorsque vous supprimez un élément, 
        /// cela s’appelle « Deque » ou « Défiler ».
        /// </summary>
        public static void UsingQueue()
        {
            Queue languages = new Queue();

            languages.Enqueue("Java");
            languages.Enqueue("C#");
            languages.Enqueue("Python");
            languages.Enqueue("C++");

            foreach (object o in languages)
            {
                Console.WriteLine(o);
            }
        }
    }
}
