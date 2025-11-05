namespace oop.classes;

class Montre
{
    private int heure;
    private int minute;
    private int seconde;

    private bool IsMinSecValid(int minSec)
    {
        if (minSec >= 0 && minSec < 60)
        {
            return true;
        }

        return false;
    }

    private bool IsHourValid(int hour)
    {
        if (hour >= 0 && hour < 59)
        {
            return true;
        }

        return false;
    }

    // Constructeur 
    public Montre(int h, int m, int s)
    {
        SetTime(h, m, s);
    }

    public Montre()
    {
        heure = 0;
        minute = 0;
        seconde = 0;
    }

    public Montre(Montre m)
    {
        SetTime(m);
    }

    public void SetTime(int h, int m, int s)
    {
        if (IsHourValid(h) && IsMinSecValid(m) && IsMinSecValid(s))
        {
            this.heure = h;
            this.minute = m;
            this.seconde = s;
        }
    }

    public void SetTime(Montre m)
    {
        SetTime(m.heure, m.minute, m.seconde);
    }

    public void AfficherMontre()
    {
        Console.WriteLine($"{heure}h{minute}m{seconde}s");
    }

    //Accesseurs
    public int Heure
    {
        get { return heure; }
        set
        {
            if (IsHourValid(value))
            {
                this.heure = value;
            }
        }
    }

    public int Minute
    {
        get { return minute; }
        set
        {
            if (IsMinSecValid(value))
            {
                this.minute = value;
            }
        }
    }

    public int Seconde
    {
        get { return seconde; }
        set
        {
            if (IsMinSecValid(value))
            {
                this.seconde = value;
            }
        }
    }
}