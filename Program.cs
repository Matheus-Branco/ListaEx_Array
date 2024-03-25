namespace ListaEx_Array
{
    /*
    Encontrar o Maior Valor da sequência 
    Encontrar o Menor Valor da sequência 
    Encontrar o Valor Médio da sequência 
    Encontrar os 3 maiores valores da sequência 
    Encontrar os valores negativos da sequência 
    Mostrar na Tela os valores da sequência 
    Remover um item da sequência 
    */
    internal class Program
    {
        #region
        static void Main(string[] args)
        {
            int[] Numeros = new int[16] { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 };

            MaiorValor(Numeros);

            MenorValor(Numeros);

            ValorMedio(Numeros);

            MaioresDaSequencia(Numeros);

            Negativos(Numeros);

            MostrarValores(Numeros);
            Numeros = RemoverElemento(Numeros);

        }
        #endregion

        #region
        static void MaiorValor(int[] Numeros)
        {
            Array.Sort(Numeros);
            Console.WriteLine(Numeros[15]);
        }
        #endregion

        #region
        static void MenorValor(int[] Numeros)
        {
            Array.Sort(Numeros);
            Console.WriteLine(Numeros[0]);
        }
        #endregion

        #region
        static void ValorMedio(int[] Numeros)
        {
            Console.WriteLine(Numeros.Average());
        }
        #endregion

        #region
        static void MaioresDaSequencia(int[] Numeros)
        {
            Array.Sort(Numeros);
            Console.Write(Numeros[13] + ", ");
            Console.Write(Numeros[14] + "e ");
            Console.Write(Numeros[15]);
        }
        #endregion

        #region
        static void Negativos(int[] Numeros)
        {
            for (int i = 0; i < 15; i++)
            {
                if (Numeros[i] < 0)
                {
                    Console.WriteLine(Numeros[i]);
                }
            }
        }
        #endregion

        #region
        static void MostrarValores(int[] Numeros)
        {
            foreach (int Numero in Numeros)
            {
                Console.WriteLine(Numero);
            }
        }
        #endregion

        #region
        static int[] RemoverElemento(int[] Numeros)
        {
            var RemoveN = Numeros.ToList();
            RemoveN.Add(5);
            Numeros = RemoveN.ToArray();
            return Numeros;
        }
        #endregion
    }
}
