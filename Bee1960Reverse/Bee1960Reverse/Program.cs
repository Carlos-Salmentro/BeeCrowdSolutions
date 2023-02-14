using System;
using System.Collections.Generic;
public class Program
{
    static void Main(string[] args)
    {
        string RomanNumber = Console.ReadLine();
        int Size = RomanNumber.Length;
        char[] RomanLetter = new char[Size];
        RomanLetter = RomanNumber.ToCharArray();
        int[] Numbers = new int[Size];

        int Subtract = 0;
        int Sum = 0;
        int Result = 0;

        for (int i = 0; i < RomanNumber.Length; i++)
        {
            if (RomanLetter[i] == 'I')
            {
                Numbers[i] = 1;
            }
            else if (RomanLetter[i] == 'V')
            {
                Numbers[i] = 5;
            }
            else if (RomanLetter[i] == 'X')
            {
                Numbers[i] = 10;
            }
            else if (RomanLetter[i] == 'L')
            {
                Numbers[i] = 50;
            }
            else if (RomanLetter[i] == 'C')
            {
                Numbers[i] = 100;
            }
            else if (RomanLetter[i] == 'D')
            {
                Numbers[i] = 500;
            }
            else
            {
                Numbers[i] = 1000;
            }

        }

        bool Status = false;

        for (int i = 0; i < Size; i++)
        {
            for (int y = i + 1; y < Size && Status == false; y++)
            {
                if (Numbers[i] < Numbers[y])
                {
                    Subtract += Numbers[i];
                    Status = true;
                }
            }

            if (Status == false)
            {
                Sum += Numbers[i];
            }

            Status = false;
        }

        Result = Sum - Subtract;
        Console.WriteLine(Result.ToString());


    }

}