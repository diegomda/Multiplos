using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista1 = new List<int>();


            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    lista1.Add(i);
                }
                if (i % 5 == 0)
                {
                    lista1.Add(i);
                }
            }

            List<int> listadoFinal = lista1.Distinct().ToList();
            foreach (var item in listadoFinal)
            {
                int suma = listadoFinal.Sum();
                Console.WriteLine(suma);
                Console.ReadKey();
            }

        }
    }
}
