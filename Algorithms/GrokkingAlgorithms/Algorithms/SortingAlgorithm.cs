using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.Algorithms
{
    internal class SortingAlgorithm
    {
        internal  int buscaMenor(int[] arr)
        {

            int menor = arr[0];  //Ordenações em um array.
            int menor_indice = 0;

            for( int i = 1; i <= arr.Length - 1; i ++)
            {
                if (arr[i] < menor)
                {
                    menor = arr[i];
                    menor_indice = i;
                }
            }
            Console.WriteLine(menor_indice);
            return menor_indice;
        }
        
        /*
        static void ordenacaoPorSelecao(int[] arr)
        {
            int[] novoArr;
            for(int i = 0; i <arr.Length; i++)
            {
                var menor = buscaMenor(arr);
                
            }
        }*/
    }
}
