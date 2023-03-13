using System;

class URI
{
    static void Main(string[] args)
    {

        int X = int.Parse(Console.ReadLine());

        int[] N = new int[10];

        for (int i = 0; i < 10; i++)
        {
            N[i] = X;
            X = X * 2;
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("N[" + i + "] = " + N[i]);
        }


    }

}
