using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Kosti
    {
        private List<int> arvot;

        public Kosti()
        {
            arvot = new List<int>();
        }
        public void AlkuTila()
        {
            if (arvot.Count == 0)
            {
                Console.WriteLine("Kosti on alkutilassa");
            }
            else
            {
                Console.WriteLine("Kosti ei ole alkutilassa, kosti sisältää {0} kappaletta arvoja", arvot.Count);
            }

        }
        public void Nollaa()
        {
            arvot.Clear();
            Console.WriteLine("Kosti nollattu");
        }
        public void SyotaArvo(int arvo)
        {
            Console.WriteLine("Kosti vastaanotti arvon: {0}", arvo);
            arvot.Add(arvo);
        }
        public void TulostaMinMax()
        {
            Console.WriteLine("Kosti minimi: {0}", arvot.Min());
            Console.WriteLine("Kosti maksimi: {0}", arvot.Max());
        }
    }
}
