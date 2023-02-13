using System;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        string Data = Console.ReadLine();

        string[] Infs = Data.Split(' ');

        double H = double.Parse(Infs[0]);
        double P = double.Parse(Infs[1]);

        double X = Math.Round(H / P, 2); 

        Console.WriteLine(X.ToString("F2", CultureInfo.InvariantCulture));
    }
}
