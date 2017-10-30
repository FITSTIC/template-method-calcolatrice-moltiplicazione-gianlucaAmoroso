using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcolatriceTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcMoltStandard moltStand = new CalcMoltStandard();
            moltStand.CalcolaMostraMolt(3, 4);

            Console.WriteLine();

            CalcMoltSommatoria moltSomm = new CalcMoltSommatoria();
            moltSomm.CalcolaMostraMolt(3, 4);

            Console.ReadKey();
        }
    }
}
