using System;

class URI
{

    static void Main(string[] args)
    {

        long[] Fib = new long[61];
        Fib[0] = 0;
        Fib[1] = 1;

        for (int i = 2; i <= 60; i++)
        {
            Fib[i] = Fib[i - 2] + Fib[i - 1];
        }

        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Fib(" + N + ") = " + Fib[N]);
        }


    }

}