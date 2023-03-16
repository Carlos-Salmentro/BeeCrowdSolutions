using System;

class URI
{
    static void Main(string[] args)
    {

        int[] N = new int[20];

        for (int i = 0; i < N.Length; i++)
        {
            int Y = int.Parse(Console.ReadLine());
            N[i] = Y;
        }

        for (int i = 0; i < N.Length / 2; i++)
        {
            int aux = N[i];
            N[i] = N[N.Length - 1 - i];

            N[N.Length - 1 - i] = aux;
        }

        for (int i = 0; i < N.Length; i++)
        {
            Console.WriteLine("N[" + i + "] = " + N[i]);
        }


    }

}