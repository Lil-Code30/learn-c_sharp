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

    public void Afficher()
    {
        Console.WriteLine($"{Heures} heures, {Minutes} minutes and {Seconds} seconds");
    }

    public int ToSecond()
    {
        int hoursToSeconds = this.Heures * 3600;
        int minutestoSeconds = this.Minutes * 60;

        int dureeToSeconds = hoursToSeconds + minutestoSeconds + this.Seconds;
        
        return dureeToSeconds;
    }
    
    // surcharges des opérateurs
    public static Duree operator +(Duree duree1, Duree duree2)
    {
        int hours = duree1.Heures + duree2.Heures;
        int minutes = duree1.Minutes + duree2.Minutes;
        int seconds = duree1.Seconds + duree2.Seconds;
        
        return new Duree(hours, minutes, seconds);
    }
    
    public static Duree operator -(Duree duree1, Duree duree2)
    {
        int hours = duree1.Heures - duree2.Heures;
        int minutes = duree1.Minutes - duree2.Minutes;
        int seconds = duree1.Seconds - duree2.Seconds;
        
        return new Duree(hours, minutes, seconds);
    }

    public static bool operator ==(Duree duree1, Duree duree2)
    {
        if (duree1.Heures == duree2.Heures && duree1.Minutes == duree2.Minutes && duree1.Seconds == duree2.Seconds)
        {
            return true;
        }
        
        return false;
    }

    public static bool operator !=(Duree duree1, Duree duree2)
    {
        return !(duree1 == duree2);
    }

    public static bool operator >(Duree duree1, Duree duree2)
    {
        if (duree1.Heures > duree2.Heures)
        {
            return true;
        }
            
        return false;
    }

    public static bool operator <(Duree duree1, Duree duree2)
    {
        if (duree1.Heures < duree2.Heures)
        {
            return true;
        }
        return false;
    }

    public static bool operator >=(Duree duree1, Duree duree2)
    {
        if (duree1.Heures >= duree2.Heures)
        {
            return true;
        }
        return false;
    }

    public static bool operator <=(Duree duree1, Duree duree2)
    {
        if (duree1.Heures <= duree2.Heures)
        {
            return true;
        }
        return false;
    }
}