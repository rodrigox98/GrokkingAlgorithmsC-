namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void buscaMenor(int[] arr )
            {

                int menor = arr[0];  //Ordenações em um array.
                int menor_indice = 0; 

                foreach(int i in arr)
                {
                    if(arr[i] < menor){
                        menor = arr[i];
                        menor_indice = i;
                    }
                    Console.WriteLine(menor_indice);
                }
            }
            static void ordenacaoPorSelecao(int[] arr)
            {
                int[] novoArr;
                
                foreach(int i in range)
            }
        }
    }
}