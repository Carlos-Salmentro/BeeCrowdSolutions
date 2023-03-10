using System;

class URI
{

    static void Main(string[] args)
    {

        int[] Numbers = new int[10];

        for (int i = 0; i < 10; i++)
        {
            int aux = int.Parse(Console.ReadLine());

            if (aux <= 0)
            {
                Numbers[i] = 1;
            }

            else
            {
                Numbers[i] = aux;
            }
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("X[" + i.ToString() + "] = " + Numbers[i]);
        }

    }

}