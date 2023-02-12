using System;
using System.Globalization;
using System.Text;

public class Program
{
    public static void Main()
    {
        decimal Value = decimal.Parse(Console.ReadLine());

        decimal[] Cash = new decimal[12];
        Cash[0] = 100.00M;
        Cash[1] = 50.00M;
        Cash[2] = 20.00M;
        Cash[3] = 10.00M;
        Cash[4] = 5.00M;
        Cash[5] = 2.00M;
        Cash[6] = 1.00M;
        Cash[7] = 0.50M;
        Cash[8] = 0.25M;
        Cash[9] = 0.10M;
        Cash[10] = 0.05M;
        Cash[11] = 0.01M;

        string[] Money = new string[12];

        Console.WriteLine("NOTAS:");

        for (int i = 0; i < 6; i++)
        {
            Money[i] = Math.Truncate(Value / Cash[i]).ToString("F0", CultureInfo.InvariantCulture);
            decimal discount = Math.Round(Cash[i] * int.Parse(Money[i]), 2);
            Value -= discount;

            Console.WriteLine($"{Money[i]} nota(s) de R$ {Cash[i].ToString("F2", CultureInfo.InvariantCulture)}");
        }

        Console.WriteLine("MOEDAS:");

        for (int i = 6; i < 12; i++)
        {
            Money[i] = Math.Truncate(Value / Cash[i]).ToString("F0", CultureInfo.InvariantCulture);
            decimal discount = Math.Round(Cash[i] * int.Parse(Money[i]), 2);
            Value -= discount;

            Console.WriteLine($"{Money[i]} moeda(s) de R$ {Cash[i].ToString("F2", CultureInfo.InvariantCulture)}");
        }


    }

}
