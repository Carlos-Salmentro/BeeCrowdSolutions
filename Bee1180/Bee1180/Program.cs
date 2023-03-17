using System;

class URI
{

    static void Main(string[] args)
    {

        int N = int.Parse(Console.ReadLine());

        string[] Datas = new string[N];
        int[] Matriz = new int[N];

        Datas = Console.ReadLine().Split(' ');

        for (int i = 0; i < N; i++)
        {
            Matriz[i] = int.Parse(Datas[i]);
        }

        int Smallest = Matriz[0];
        int Position = 0;

        for (int i = 1; i < N; i++)
        {
            if (Matriz[i] < Smallest)
            {
                Smallest = Matriz[i];
                Position = i;
            }
        }

        Console.WriteLine("Menor valor: " + Smallest.ToString());
        Console.WriteLine("Posicao: " + Position.ToString());


    }

}