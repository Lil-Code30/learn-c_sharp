namespace oop_practise.classes
{
    public class Etudiant
    {
        protected string nom;
        protected string adresse;

        public Etudiant(string nom, string adresse)
        {
            this.nom = nom;
            this.adresse = adresse;
        }

        public virtual void Afficher()
        {
            Console.WriteLine("=== Étudiant ===");
            Console.WriteLine($"Nom     : {nom}");
            Console.WriteLine($"Adresse : {adresse}");
            Console.WriteLine();
        }

        public virtual int PaiementSession(int nbreCours)
        {
            int prixCourUnite = 300;
            int prixAssurance = 500;

            int fraisTotal = (nbreCours * prixCourUnite) + prixAssurance;
            return fraisTotal;

            // Console.WriteLine("=== Paiement session (Étudiant) ===");
            // Console.WriteLine($"Nombre de cours  : {nbreCours}");
            // Console.WriteLine($"Prix par cours   : {prixCourUnite} ");
            // Console.WriteLine($"Prix assurance   : {prixAssurance} ");
            // Console.WriteLine($"Frais total      : {fraisTotal} ");
            // Console.WriteLine();

        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
    }

    public class EtudiantEtranger : Etudiant
    {
        private string paysOrigine;

        public EtudiantEtranger(string nom, string adresse, string paysOrigine) : base(nom, adresse)
        {
            this.paysOrigine = paysOrigine;
        }

        public override int PaiementSession(int nbreCours)
        {
            int prixCourUnite = 1000;
            int prixAssurance = 2500;

            int fraisTotal = (nbreCours * prixCourUnite) + prixAssurance;
            return fraisTotal;

            // Console.WriteLine("=== Paiement session (Étudiant étranger) ===");
            // Console.WriteLine($"Nombre de cours  : {nbreCours}");
            // Console.WriteLine($"Prix par cours   : {prixCourUnite} ");
            // Console.WriteLine($"Prix assurance   : {prixAssurance} ");
            // Console.WriteLine($"Frais total      : {fraisTotal} ");
            // Console.WriteLine();
        }

        public override void Afficher()
        {
            Console.WriteLine("=== Étudiant étranger ===");
            Console.WriteLine($"Nom            : {nom}");
            Console.WriteLine($"Adresse        : {adresse}");
            Console.WriteLine($"Pays d'origine : {paysOrigine}");
            Console.WriteLine();
        }


        public string PaysOrigine
        {
            get { return paysOrigine; }
            set { paysOrigine = value; }
        }
    }
}
