namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lista1 = { 1, 10, 23, 35, 42, 65, 71, 82, 90, 100};

            static void pesquisaBinaria(int[] lista, int item) 
            { 
                //Declarando array com 25 elementos
                

                int baixo = 0; // Índice 0
                int alto = lista.Length - 1; // Índice 24

                while (baixo <= alto)
                {
                    int meio = (baixo + alto) / 2;
                    int chute = lista[meio];

                    if(chute == item)
                    {
                        Console.WriteLine($"O número: {lista[meio]} foi achado e está localizado na posição {meio}");
                    }
                    if(chute > item)
                    {
                        alto = meio - 1;
                    }
                    else
                    {
                        baixo = meio + 1;
                    } 
                }
                
            }

            pesquisaBinaria(lista1, 65);
        }
    }
}