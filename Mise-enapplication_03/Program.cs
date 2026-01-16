using Mise_enapplication_03.classes;

// Création de 5 livres
Livre l1 = new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", 1);
Livre l2 = new Livre("Candide", "Voltaire", 2);
Livre l3 = new Livre("L'Étranger", "Albert Camus", 3);
Livre l4 = new Livre("Les Misérables", "Victor Hugo", 4);
Livre l5 = new Livre("Vingt Mille Lieues Sous les Mers", "Jules Verne", 5);

Bibliothecaire e1 = new Bibliothecaire("Loko Ismael", "Bibliothecaire", 302, "loko@tech.com");

e1.Louer(l4);

l4.Afficher();

Console.WriteLine();
Console.WriteLine("****************************************");
Console.WriteLine();

e1.Retour(l4);

l4.Afficher();