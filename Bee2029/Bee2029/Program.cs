using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        double Pi = 3.14;

        while (true)
        {
            string vol = Console.ReadLine();
            if (string.IsNullOrEmpty(vol))
            {
                break;
            }

            else
            {
                double Vol = Convert.ToDouble(vol, CultureInfo.InvariantCulture);
                double d = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                double H = Vol / (Pi * Math.Pow((d / 2.0), 2.00));
                double Area = Pi * Math.Pow((d / 2.0), 2.00);

                Console.WriteLine("ALTURA = " + H.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("AREA = " + Area.ToString("F2", CultureInfo.InvariantCulture));
            }
        }

    }
}