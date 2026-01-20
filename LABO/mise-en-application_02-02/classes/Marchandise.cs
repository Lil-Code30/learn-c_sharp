namespace mise_en_application_02_02.classes;

public class Marchandise
{
    public float Poids { get; }
    public float Volume { get; }

    public Marchandise(float poids, float volume)
    {
        Poids = poids;
        Volume = volume;
    }
}