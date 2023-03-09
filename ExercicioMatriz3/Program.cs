internal class Program
{
    private static void Main(string[] args)
    {
        int[,] m = new int[5, 5];
        int[,] m2 = new int[5, 5];
        Random sorteio = new Random();

        //Carregar valores na matriz
        for (int c = 0; c < m.GetLength(1); c++)
        {
            for (int l = 0; l < m.GetLength(0); l++)
            {
                m[l, c] = sorteio.Next(100);
            }
        }

        //Carregar valores na matriz m2
        for (int c = 0; c < m2.GetLength(1); c++)
        {
            for (int l = 0; l < m2.GetLength(0); l++)
            {
                m2[l, c] = sorteio.Next(100);
            }
        }

        //Imprimir números aleatórios
        for (int l = 0; l < m.GetLength(0); l++)
        {
            for (int c = 0; c < m.GetLength(1); c++)
            {
                Console.Write("\tm" + "[" + l + "," + c + "]" + "= " + m[l, c]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //Imprimir números aleatórios m2
        for (int l = 0; l < m2.GetLength(0); l++)
        {
            for (int c = 0; c < m2.GetLength(1); c++)
            {
                Console.Write("\tm" + "[" + l + "," + c + "]" + "= " + m2[l, c]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //Inverter m2 e m1
        for (int l = 0; l < m.GetLength(0); l++)
        {
            for (int c = 0; c < m.GetLength(1); c++)
            {
                m2[m.GetLength(0) - 1 - l, m.GetLength(1) - 1 - c] = m[l, c];
            }
        }

        //Imprimir números m2 invertidos
        for (int l = 0; l < m2.GetLength(0); l++)
        {
            for (int c = 0; c < m2.GetLength(1); c++)
            {
                Console.Write("\tm" + "[" + l + "," + c + "]" + "= " + m2[l, c]);
            }
            Console.WriteLine();
        }

    }
}