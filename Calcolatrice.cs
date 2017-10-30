using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcolatriceTemplateMethod
{
    interface ICalcolatrice
    {
        void CalcolaMostraMolt(int x, int y);
    }

    abstract class Calcolatrice : ICalcolatrice
    {
        protected int x, y, res;

        protected void InserisciPrimoNumero(int x)
        {
            this.x = x;
        }

        protected void InserisciSecondoNumero(int y)
        {
            this.y = y;
        }

        protected abstract void CalcolaMolt();

        protected abstract void ScriviResult();

        public void CalcolaMostraMolt(int x, int y)
        {
            InserisciPrimoNumero(x);
            InserisciSecondoNumero(y);
            CalcolaMolt();
            ScriviResult();
        }
    }

    class CalcMoltStandard : Calcolatrice
    {
        protected override void CalcolaMolt()
        {
            res = x * y;
        }

        protected override void ScriviResult()
        {
            Console.WriteLine("Il risultato tramite moltiplicazione standard è " + res);
        }
    }

    class CalcMoltSommatoria : Calcolatrice
    {
        protected override void CalcolaMolt()
        {
            int numDaSommare, sommatoria;
            if(x <= y)
            {
                numDaSommare = y;
                sommatoria = x;
            }
            else
            {
                numDaSommare = x;
                sommatoria = y;
            }
            for(int i = 1; i <= sommatoria; i++)
            {
                res += numDaSommare;
            }
        }

        protected override void ScriviResult()
        {
            Console.WriteLine("Il risultato tramite moltiplicazione con sommatoria è " + res);
        }
    }
}
