using Mise_en_application_6.Classes;

namespace Mise_en_application_6.Exercices
{
    public static class Exercice01_GestionPile
    {
        public static void Executer()
        {
            Console.WriteLine("=== DÉBUT DES TESTS ===\n");
            Console.WriteLine("Gestion d’une pile de dossiers d’assurance ");
            GestionPile gestion = new GestionPile();

            // --- TC01 & TC02: Add Multiple ---
            Console.WriteLine("--- TEST: Ajout Multiple ---");
            var d1 = new DossierAssurance("D001", "Jean", "Auto", "Ouvert");
            var d2 = new DossierAssurance("D002", "Marie", "Maison", "En cours");
            var d3 = new DossierAssurance("D003", "Paul", "Vie", "Fermé");

            gestion.GererPileDossiers("ajouter", d1);
            gestion.GererPileDossiers("ajouter", d2);
            gestion.GererPileDossiers("ajouter", d3);

            // --- TC03: Consult Non-Empty (Should show D003) ---
            Console.WriteLine("\n--- TEST: Consulter (Non-vide) ---");
            gestion.GererPileDossiers("consulter", null);

            // --- TC05: Remove One (Removes D003) ---
            Console.WriteLine("\n--- TEST: Retirer (Non-vide) ---");
            gestion.GererPileDossiers("retirer", null);

            // --- TC03 Again: Consult (Should show D002) ---
            Console.WriteLine("\n--- TEST: Consulter après retrait ---");
            gestion.GererPileDossiers("consulter", null);

            // --- TC07: Invalid Action ---
            Console.WriteLine("\n--- TEST: Action Invalide ---");
            gestion.GererPileDossiers("supprimer", null);

            // --- Clean up for Empty Tests ---
            GestionPile.PileDossiers.Clear();
            Console.WriteLine("\n(PILE VIDÉE MANUELLEMENT POUR LA SUITE)\n");

            // --- TC04: Consult Empty ---
            Console.WriteLine("--- TEST: Consulter (Vide) ---");
            gestion.GererPileDossiers("consulter", null);

            // --- TC06: Remove Empty ---
            Console.WriteLine("\n--- TEST: Retirer (Vide) ---");
            gestion.GererPileDossiers("retirer", null);

            Console.WriteLine("\n=== FIN DES TESTS ===");
        }
    }
}
