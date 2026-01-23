using mise_en_application_02_06.interfaces;
namespace mise_en_application_02_06.classes
{
    public class Rectangle : Forme, IDessinable
    {
        public double Largeur { get; }
        public double Hauteur { get; }

        public Rectangle(double largeur, double hauteur)
        {
            Largeur = largeur;
            Hauteur = hauteur;
        }

        public override void CalculerSurface()
        {
            double surface = Largeur * Hauteur;

            Console.WriteLine($"Rectamgle avec largeur : {Largeur} et hauteur {Hauteur} donne une Surface de {surface:F} m2");
        }

        public void Dessiner()
        {
            Console.WriteLine("Reactangle");
        }
    }
}
