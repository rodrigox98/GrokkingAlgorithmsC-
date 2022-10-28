using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.Algorithms
{
    internal class BinarySearch
    {
        int[] lista1 = { 1, 10, 23, 35, 42, 65, 71, 82, 90, 100, 150, 200, 220, 276, 283, 301 };

        static void pesquisaBinaria(int[] lista, int item)
        {

            int baixo = 0; // Índice 0
            int alto = lista.Length - 1; // Índice 24

            while (baixo <= alto)
            {
                int meio = (baixo + alto) / 2;
                int chute = lista[meio];

                if (chute == item)
                {
                    Console.WriteLine($"O número: {lista[meio]} foi achado e está localizado na posição {meio}");
                    break;
                }
                if (chute > item)
                {
                    alto = meio - 1;
                }
                else
                {
                    baixo = meio + 1;
                }
            }
            Console.WriteLine("O " + item + " não existe na lista.");
        }
        pesquisaBinaria(lista1, 221);
    }
}
