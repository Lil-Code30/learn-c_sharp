using Mise_en_application.mea01.classes.Ex01;

class Program
{
    static void Main()
    {

        // Facture 1
        Facture f1 = new Facture("Alice Dupont", "Jean Martin");
        f1.ajoutArticle(new Article("Clavier mécanique", 2, 89.99f));
        f1.ajoutArticle(new Article("Souris gaming", 1, 45.50f));

        // Facture 2
        Facture f2 = new Facture("Société Tech SARL", "Marie Lefevre");
        f2.ajoutArticle(new Article("Écran 27\" 4K", 5, 320.00f));
        f2.ajoutArticle(new Article("Support mural", 5, 25.00f));

        // Facture 3
        Facture f3 = new Facture("Pierre Dubois", "Olivier Bernard");
        f3.ajoutArticle(new Article("Casque Bluetooth", 1, 120.00f));

        // Facture 4
        Facture f4 = new Facture("Boulangerie du Centre", "Sophie Moreau");
        f4.ajoutArticle(new Article("Imprimante thermique", 1, 199.90f));
        f4.ajoutArticle(new Article("Rouleaux de papier", 10, 8.50f));

        // Facture 5
        Facture f5 = new Facture("École Municipale", "Admin Services");
        f5.ajoutArticle(new Article("Stylos bille (boîte de 50)", 3, 12.99f));
        f5.ajoutArticle(new Article("Cahiers A4", 20, 2.30f));
        f5.ajoutArticle(new Article("Classeurs rigides", 10, 4.75f));

        // Affichage

        f1.afficher();
        f2.afficher();
        f3.afficher();
        f4.afficher();
        f5.afficher();
    }
}