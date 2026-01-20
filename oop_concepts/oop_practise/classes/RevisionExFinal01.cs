namespace oop_practise.classes
{

    public abstract class ClasseA
    {
        protected int a1;
        protected int a2;

        public ClasseA(int a1, int a2)
        {
            this.a1 = a1;
            A2 = a2;
        }

        public abstract void Affichage();
        public virtual int Calcul(int z)
        {
            z = z + 2;
            return z;
        }

        // Proposer une solution pour que a2 puisse être affiché et modifié de n’importe où à condition que sa valeur soit entre 5 et 10 
        public int A2
        {
            get { return a2; }
            set
            {
                if (value >= 5 && value <= 10)
                {
                    a2 = value;
                }
            }

        }
    }

    public class ClasseB : ClasseA
    {
        public ClasseB(int a1, int a2) : base(a1, a2)
        {

        }

        public override void Affichage()
        {

        }

        public void Affichage(int x)
        {
            Console.WriteLine(a1 * x);
        }

        public int Calcul(ClasseC objC)
        {
            objC.a3 = objC.a3 * a2;
            return objC.a3;
        }
    }

    public class ClasseC : ClasseA
    {
        public int a3;

        public ClasseC(int a1, int a2, int a3) : base(a1, a2)
        {
            this.a3 = a3;
        }

        public override void Affichage()
        {
            Console.WriteLine(a3);
        }

        public override int Calcul(int y)
        {
            y = y - a1;
            return y;
        }
    }
}
