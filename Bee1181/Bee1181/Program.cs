using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        float[,] M = new float[12, 12];
        int L = int.Parse(Console.ReadLine());
        char T = char.Parse(Console.ReadLine());

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                M[i, j] = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
        }

        if (T == 'S')
        {
            float sum = 0.00f;

            for (int j = 0; j < 12; j++)
            {
                sum += M[L, j];
            }

            Console.WriteLine(sum.ToString("F1", CultureInfo.InvariantCulture));
        }

        else
        {
            float sum = 0.00f;

            for (int j = 0; j < 12; j++)
            {
                sum += M[L, j];
            }

            float result = sum / 12.0f;
            Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture));
        }





    }

}