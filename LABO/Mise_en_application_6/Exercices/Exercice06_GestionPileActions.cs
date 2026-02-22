using Mise_en_application_6.Classes;

namespace Mise_en_application_6.Exercices
{
    public static class Exercice06_GestionPileActions
    {
        public static void Executer()
        {
            Console.WriteLine("=== DÉBUT DU TEST HISTORIQUE ===\n");

            // 1. Ajout initial
            GestionPileActions.GererHistorique("ajouter", "Bonjour ");
            // État attendu: "Bonjour "

            // 2. Deuxième ajout
            GestionPileActions.GererHistorique("ajouter", "le monde");
            // État attendu: "Bonjour le monde"

            // 3. Annulation (Undo)
            GestionPileActions.GererHistorique("undo", "");
            // État attendu: "Bonjour " (On revient en arrière)

            // 4. Rétablissement (Redo)
            GestionPileActions.GererHistorique("redo", "");
            // État attendu: "Bonjour le monde" (On revient en avant)

            // 5. Nouvelle modification (Casse la chaîne de Redo)
            GestionPileActions.GererHistorique("ajouter", "à tous");
            // État attendu: "Bonjour le mondeà tous" 
            // NOTE: La pile Redo devrait être vide maintenant.

            // 6. Tentative de Redo (Devrait échouer)
            //GestionPileActions.GererHistorique("redo", "");

            // 7. Annulations en cascade
            //GestionPileActions.GererHistorique("undo", "");
            //GestionPileActions.GererHistorique("undo", "");
            //GestionPileActions.GererHistorique("undo", ""); // Devrait afficher "Rien à annuler"

            Console.WriteLine("\n=== FIN DU TEST ===");
        }
    }
}
