namespace mise_en_application_02_02.classes;

public class TransportRoutier : Transport
{
    public override double Tarif(Marchandise marchandise)
    {
        int prixUnitaire = 2;
        double tarif = prixUnitaire * marchandise.Volume;
        return tarif;
    }
}