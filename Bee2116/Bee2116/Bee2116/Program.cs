using System;

class URI
{

    static void Main(string[] args)
    {

        string[] Array = Console.ReadLine().Split(' ');

        double N = double.Parse(Array[0]);
        double M = double.Parse(Array[1]);

        int P1 = 0;
        int P2 = 0;

        int count = 0;

        if (N == 2)
        {
            P1 = 2;
        }

        else
        {
            for (int i = 2; i <= N && count == 0; i++)
            {
                double x = Convert.ToDouble(i);

                if (N % x == 0 && i != N)
                {
                    i = 1;
                    N--;
                }
                if (i == N)
                {
                    P1 = Convert.ToInt32(N);
                    count++;
                }
            }
        }

        count = 0;

        if (M == 2)
        {
            P2 = 2;
        }

        else
        {
            for (int i = 2; i <= M && count == 0; i++)
            {
                double x = Convert.ToDouble(i);

                if (M % x == 0 && i != M)
                {
                    i = 1;
                    M--;
                }
                if (i == M)
                {
                    P2 = Convert.ToInt32(M);
                    count++;
                }
            }
        }


        Console.WriteLine(P1 * P2);
    }

}