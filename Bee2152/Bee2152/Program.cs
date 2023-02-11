using System;

public class Program
{
    public static void Main()
    {
        string Status;
        int X = int.Parse(Console.ReadLine());

        for (int i = 0; i < X; i++)
        {

            string data = Console.ReadLine();
            string[] array = data.Split(' ');

            string H = array[0].PadLeft(2, '0');
            string M = array[1].PadLeft(2, '0');
            int O = int.Parse(array[2]);

            if (O == 0)
            {
                Status = "A porta fechou!";
            }

            else
            {
                Status = "A porta abriu!";
            }

            Console.WriteLine($"{H}:{M} - {Status}");

        }
    }
}