using System;
class URI
{

    static void Main(string[] args)
    {

        int[] Matriz = new int[1000];

        int aux = 0;

        int T = int.Parse(Console.ReadLine());

        while (aux < 1000)
        {
            for (int i = 0; i < T && aux < 1000; i++)
            {
                Matriz[aux] = i;
                aux++;
            }
        }

        for (int i = 0; i < 1000; i++)
        {
            Console.WriteLine("N[" + i + "] = " + Matriz[i]);
        }

    }

}