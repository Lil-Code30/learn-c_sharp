using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_practise.classes
{
    public abstract class ClassA
    {
        protected int a1;

        public ClassA(int a1)
        {
            this.a1 = a1;
        }

        public abstract void Show();
        public int Modify(int x)
        {
            x = a1 - x;
            return x;
        }
    }

    public class ClassB : ClassA
    {
        private int b1;

        public ClassB(int a1, int b1) : base(a1)
        {
            this.b1 = b1;
        }

        public override void Show()
        {
            Console.WriteLine(a1 + "" + b1);
        }

        public virtual void Show(int x)
        {
            Console.WriteLine(b1 + "" + x);
        }

        public int B1
        {
            get { return b1; }
            set { b1 = value; }
        }
    }

    public class ClassC : ClassA
    {
        private int c1;

        public ClassC(int a1, int c1) : base(a1)
        {
            this.c1 = c1;
        }

        public override void Show()
        {
            Console.WriteLine(a1 + "" + c1);
        }

        public int Modify(ClassB objB)
        {
            objB.B1 = objB.B1 - c1;
            return objB.B1;
        }
    }

    public class ClassD : ClassB
    {
        public int d1;

        public ClassD(int a1, int b1, int d1) : base(a1, b1)
        {
            this.d1 = d1;
        }

        public override void Show(int z)
        {
            Console.WriteLine(d1);
        }
    }
    
}
