using stockManagement.classes;

// Création des produits (AGRÉGATION)
Produit coca = new Produit(1, "Coca-Cola", 50);
Produit pepsi = new Produit(2, "Pepsi", 30);
Produit eau = new Produit(3, "Eau Minérale", 100);

// Création du magasin
Magasin magasin = new Magasin("SuperShop");

magasin.AjouterProduit(coca);
magasin.AjouterProduit(pepsi);
magasin.AjouterProduit(eau);

magasin.AfficherStock();

// Création d'une transaction (COMPOSITION)
Transaction t1 = new Transaction(101);
t1.AjouterLigne(coca, 2);
t1.AjouterLigne(pepsi, 1);

magasin.AjouterTransaction(t1);

magasin.AfficherTransactions();
magasin.AfficherStock();

Console.WriteLine("\n✅ Fin du programme");