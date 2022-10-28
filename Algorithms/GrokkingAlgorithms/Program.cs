using GrokkingAlgorithms.Algorithms;
using System.Collections.Generic;

namespace GrokkingAlgorithms
{
    internal class Program
    {

        static void Main(string[] args)
        {
           /* int[] lista1 = { 1, 10, 23, 35, 42, 65, 71, 82, 90, 100, 150, 200, 220, 276, 283, 301 };
            BinarySearch array = new BinarySearch();
            array.pesquisaBinaria(lista1, 150); */

            int[] lista2 = { 9,8,7,6,5 };
            SortingAlgorithm array2 = new SortingAlgorithm();
            array2.buscaMenor(lista2);
        }
    }
}