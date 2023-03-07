using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        int valor;
        int[] A = new int[5];
        int[] B = new int[5];
        int[] C = new int[10];

        LerVetor(A, " Vetor A");
        LerVetor(B, " Vetor B");

        C= Concatenar_Vetor(A, B);

        ImprimirValor(A, "Vetor A");
        ImprimirValor(B, "Vetor B");
        ImprimirValor(C, "Vetor C");

        OrdenarVetor(C);
        ImprimirValor(C, "Vetor C");


        void LerVetor(int[] aux, string texto)
        {
            //Leitura do Vetor
            Console.WriteLine("Informe os valores do vetor {0}:  ", texto);
            for (int i = 0; i < aux.Length; i++)
            {
                Console.WriteLine("\nVetor[{0}]=  ", i );
                aux[i] = int.Parse(Console.ReadLine());
            }
        }

        void ImprimirValor(int[]aux, string texto)
        {
            //Impressão do Vetor
            Console.WriteLine("\nOs valores do vetor {0} são: ", texto);
            for (int i = 0; i < aux.Length; i++)
            {
                Console.Write("\nVetor[{0}]=  {1}", i, aux[i]);
                
            }
        }

        int[] Concatenar_Vetor(int[]A, int[]B)
        {
            int[] aux = new int[10]; 
            for(int i=0; i < A.Length; i++)
                aux[i] = A[i];
            for(int i=0; i <B.Length; i++)
                aux[i + 5] = B[i];

            return aux;
        }

        void OrdenarVetor(int[]v)
        {
            int i, j;
            

            for( i=0; i < v.Length-1; i++)
            {
                for(j = i+1; j < v.Length; j++)
                {
                    if (v[i] > v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;

                    }
                }
            }
        }

    }

}