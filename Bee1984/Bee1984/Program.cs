using System;
using System.Text;
class URI
{
    static void Main(string[] args)
    {
        string Data = Console.ReadLine();
        int X = Data.Length - 1;
        StringBuilder Sb = new StringBuilder();

        for (int i = 0; i <= X; i++)
        {
            Sb.Append(Data[X - i]);
        }

        Console.WriteLine(Sb.ToString());
    }

}