using Mise_en_application_6.Classes;

namespace Mise_en_application_6.Exercices
{
    public static class Exercice02_GestionFile
    {
        public static void Executer()
        {
            // 🚀 Données de test - 10 commandes à copier dans Main
            var gestion = new GestionFile();
            GestionFile.queueCommandes.Clear(); // Reset de la file statique

            Console.WriteLine("🍕 INITIALISATION : Ajout de 10 commandes dans la file\n");

            // ─────────────────────────────────────────────────────
            // 📦 AJOUT DES 10 COMMANDES
            // ─────────────────────────────────────────────────────

            gestion.GererCommandes("ajouter", new Commande { Code = "CMD001", TypePizza = "Margherita", Prix = 12.50, Statut = "En attente" });
            gestion.GererCommandes("ajouter", new Commande { Code = "CMD002", TypePizza = "Pepperoni", Prix = 15.00, Statut = "En attente" });
            gestion.GererCommandes("ajouter", new Commande { Code = "CMD003", TypePizza = "Quatre Fromages", Prix = 14.75, Statut = "En attente" });
            gestion.GererCommandes("ajouter", new Commande { Code = "CMD004", TypePizza = "Végétarienne", Prix = 13.25, Statut = "En attente" });
            gestion.GererCommandes("ajouter", new Commande { Code = "CMD005", TypePizza = "Hawaïenne", Prix = 16.00, Statut = "En attente" });
            gestion.GererCommandes("ajouter", new Commande { Code = "CMD006", TypePizza = "Calzone", Prix = 14.50, Statut = "En attente" });
            gestion.GererCommandes("ajouter", new Commande { Code = "CMD007", TypePizza = "Diavola", Prix = 15.50, Statut = "En attente" });
            gestion.GererCommandes("ajouter", new Commande { Code = "CMD008", TypePizza = "Napolitaine", Prix = 13.75, Statut = "En attente" });
            gestion.GererCommandes("ajouter", new Commande { Code = "CMD009", TypePizza = "Reine", Prix = 14.00, Statut = "En attente" });
            gestion.GererCommandes("ajouter", new Commande { Code = "CMD010", TypePizza = "Spéciale Maison", Prix = 18.50, Statut = "En attente" });

            // ─────────────────────────────────────────────────────
            // 🎯 EXEMPLES D'OPÉRATIONS 
            // ─────────────────────────────────────────────────────

            // ✅ Traiter la première commande (CMD001 - FIFO)
             gestion.GererCommandes("traiter", null);

            // ✅ Annuler une commande spécifique (ex: CMD005)
             gestion.GererCommandes("annuler", new Commande { Code = "CMD005" });

            // ✅ Tenter d'annuler une commande inexistante
             gestion.GererCommandes("annuler", new Commande { Code = "CMD999" });

            // ✅ Traiter 3 commandes d'affilée
            gestion.GererCommandes("traiter", null);
             gestion.GererCommandes("traiter", null);
             gestion.GererCommandes("traiter", null);

            // ✅ Action invalide
             gestion.GererCommandes("supprimer", null);

            // ─────────────────────────────────────────────────────
            // 📊 AFFICHAGE FINAL
            // ─────────────────────────────────────────────────────
            Console.WriteLine("\n✅ TESTS TERMINÉS");
            Console.WriteLine($"📦 Commandes restantes : {GestionFile.queueCommandes.Count}");
            Console.WriteLine($"💰 Valeur totale : {GestionFile.queueCommandes.Sum(c => c.Prix):F2} $");
        }
    }
}
