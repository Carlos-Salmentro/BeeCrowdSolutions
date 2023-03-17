using System;

class URI
{

    static void Main(string[] args)
    {

        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            int aux = 1;
            int sum = 0;
            int X = int.Parse(Console.ReadLine());

            while (aux < X)
            {
                if (X % aux == 0.00)
                {
                    sum += aux;
                }

                aux++;
            }

            if (X == sum)
            {
                Console.WriteLine(X + " eh perfeito");
            }

            else
            {
                Console.WriteLine(X + " nao eh perfeito");
            }
        }

    }

}