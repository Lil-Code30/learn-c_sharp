namespace mise_en_application_02_ex03.classes;

public class Duree
{
    public int Heures { get; set; }
    public int  Minutes {get; set;}
    public int Seconds {get; set;}

    public Duree(int heures, int minutes, int seconds)
    {
        Heures = heures;
        Minutes = minutes;
        Seconds = seconds;
    }

    public static Duree operator +(Duree duree1, Duree duree2)
    {
        int hours = duree1.Heures + duree2.Heures;
        int minutes = duree1.Minutes + duree2.Minutes;
        int seconds = duree1.Seconds + duree2.Seconds;
        
        return new Duree(hours, minutes, seconds);
    }
}