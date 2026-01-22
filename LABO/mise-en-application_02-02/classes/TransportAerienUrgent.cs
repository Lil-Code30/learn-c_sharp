namespace mise_en_application_02_02.classes;

public class TransportAerienUrgent : TransportAerien
{
    public override double Tarif(Marchandise marchandise)
    {
        int prixUnitaire = 10;
        double tarif = prixUnitaire * marchandise.Poids;
        return tarif * 2;
    }
    
}