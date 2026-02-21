using collections_in_csharp.Collections;

Console.WriteLine("Working with collections in C#");
Console.WriteLine("################################");

Console.WriteLine("1. Les collections non génériques");
Console.WriteLine("1.1. ArrayList");
NonGenericsCollection.UsingArrayList();
Console.WriteLine("_____________________________________________________________");
Console.WriteLine("1.2. HashTable");
NonGenericsCollection.UsingHashTable();
Console.WriteLine("_____________________________________________________________");
Console.WriteLine("1.3. SortedList");
NonGenericsCollection.UsingStortedList();
Console.WriteLine("_____________________________________________________________");
Console.WriteLine("1.4. Stack");
NonGenericsCollection.UsingStack();
Console.WriteLine("_____________________________________________________________");
Console.WriteLine("1.5. Queue");
NonGenericsCollection.UsingQueue();

Console.WriteLine();

Console.WriteLine("################################");

Console.WriteLine();
Console.WriteLine("2. Les collections génériques");