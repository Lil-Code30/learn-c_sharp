
namespace Mise_en_application_02.CLasses
{
    public class Etudiant
    {
        private string nom;
        private string prenom;
        private readonly float note;

        public Etudiant(string nom, string prenom, float note)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.note = note;

        }

        public  void afficherEtudiant()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("           CARTE ÉTUDIANT      ");
            Console.WriteLine("==================================");
            Console.WriteLine($"Nom      : {nom}");
            Console.WriteLine($"Prénom   : {prenom}");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Note     : {note}/20");
            Console.WriteLine("==================================");
        }

        public float Note
        {
            get { return note; }
        }
    }
}
