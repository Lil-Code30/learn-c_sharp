

namespace Mise_en_application_02.CLasses
{
    public class Etudiant
    {
        private List<float> notes;
        private float moyenne;

        public Etudiant()
        {
            this.notes = new List<float>();
            this.moyenne = 0;
        }

        public void ajouteNote(float note)
        {
            notes.Add(note);
        }

        public float calculMoyenne()
        {
            int nombresDeNote = notes.Count();

            float total = 0;

            foreach(float note in notes)
            {
                total = total + note;
            }

             this.moyenne = total / nombresDeNote;

            return moyenne;
        }

        public void afficherNotes()
        {
            Console.WriteLine("=========== Vos Notes ==========");
            foreach(float note in notes)
            {
                int i = 1;
                Console.WriteLine("---------------------");
                Console.WriteLine($"Note: {i} - {note}");
                Console.WriteLine("---------------------");
                i++;
            }
            Console.WriteLine("=================================");
        }
    }
}
