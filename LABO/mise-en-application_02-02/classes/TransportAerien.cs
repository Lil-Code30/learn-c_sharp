namespace mise_en_application_02_02.classes;

public class TransportAerien : Transport
{
    public override double Tarif(Marchandise marchandise)
    {
        int prixUnitaire = 10;
        double tarif = prixUnitaire * marchandise.Poids;
        return tarif;
    }
}