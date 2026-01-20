using mise_en_application_02_02;
namespace mise_en_application_02_02.classes;

public abstract class Transport : ITransport
{
    public abstract double Tarif(Marchandise marchandise);
}