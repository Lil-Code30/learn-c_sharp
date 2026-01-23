using Mise_en_application_02_04.interfaces;
namespace Mise_en_application_02_04.classes;

public class AbonnementAnnuel : IAbonnement
{
    private double _montantFix = 500;
    public double CalculerMontant()
    {
        return _montantFix;
    }

    public void AfficherFacture()
    {
        
        Console.WriteLine("======================== Facture ========================");
        Console.WriteLine("Type Abonnement : Abonnememt Annuel");
        Console.WriteLine($"Montant Fixe : {_montantFix}");
        Console.WriteLine("=========================================================");
        
    }
}