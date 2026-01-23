
using mise_en_application_02_05;

Produit pcgamer = new Produit("PC Gamer", 2500.35f);

Console.WriteLine("BEFORE");
pcgamer.Afficher();

pcgamer.AjouterStock(5);
Console.WriteLine("AFTER");
pcgamer.Afficher();