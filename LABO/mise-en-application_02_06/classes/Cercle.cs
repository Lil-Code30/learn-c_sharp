using mise_en_application_02_06.interfaces;
namespace mise_en_application_02_06.classes
{
    public class Cercle : Forme, IDessinable
    {
        public double Rayon { get; }

        public Cercle(double rayon)
        {
            Rayon = rayon;
        }

        public override void CalculerSurface()
        {

            double surface = 3.14 * Rayon * Rayon;

            Console.WriteLine($"Un Cercle avec un rayon de {Rayon} donne une surface de {surface}");
        }

        public void Dessiner()
        {
            Console.WriteLine("Cercle");
        }
    }
}
