
namespace Mise_en_application_02.CLasses
{
    public class Etudiant
    {
        private string nom;
        private string prenom;
        private readonly float note;
        private List<float> notes = new List<float>();

        public Etudiant(string nom, string prenom, float note)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.note = note;

        }

        public double calculMoyenne()
        {
            double sum = 0;
            foreach (float note in notes)
            {
                sum += note;
            }
            
            return sum / notes.Count;
        }

        public  void afficherEtudiant()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("           CARTE ÉTUDIANT      ");
            Console.WriteLine("==================================");
            Console.WriteLine($"Nom      : {nom}");
            Console.WriteLine($"Prénom   : {prenom}");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Moyenne : {calculMoyenne():F}");
            Console.WriteLine("==================================");
        }

        public void AjouteNote(float note)
        {
                notes.Add(note);
        }

        public float Note
        {
            get { return note; }
        }
    }
}
