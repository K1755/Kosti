using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kosti laite = new Kosti();

            laite.AlkuTila();
            laite.SyotaArvo(15);
            laite.SyotaArvo(17);
            laite.SyotaArvo(12);
            laite.TulostaMinMax();
            laite.Nollaa();

            Console.ReadLine();

        }
    }
}
