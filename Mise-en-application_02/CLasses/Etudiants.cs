

namespace Mise_en_application_02.CLasses
{
    public static class Etudiants
    {
        private static List<Etudiant> etudiants = new List<Etudiant>();
        private static float moyenne = 0;

       

        public static void ajouteEtudiant(Etudiant etudiant)
        {
            etudiants.Add(etudiant);
        }

        public static float calculMoyenne()
        {
            int nombresDesEtudiant = etudiants.Count();

            float total = 0;

            foreach(Etudiant etudiant in etudiants)
            {
                total = total + etudiant.Note;
            }

             moyenne = total / nombresDesEtudiant;

            return moyenne;
        }

        public static void afficherEtudiant()
        {
            Console.WriteLine("=========== Liste des Etudiant ==========");
            foreach(Etudiant etudiant in etudiants)
            {
                etudiant.afficherEtudiant();
            }
            Console.WriteLine("=========================================");
        }
    }
}
