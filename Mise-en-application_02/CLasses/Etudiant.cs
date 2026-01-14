

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
    }
}
