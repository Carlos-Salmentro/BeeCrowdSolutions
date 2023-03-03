using System;
using System.Text;

class URI
{
    static void Main(string[] args)
    {
        while (true)
        {
            string line = Console.ReadLine();

            int Open = 0;
            int Close = 0;
            int Test = 0;

            if (line == null || line == String.Empty)
            {
                break;
            }

            for (int i = 0; i < line.Length && Test >= 0; i++)
            {
                if (line[i] == '(')
                {
                    Open++;
                    Test++;
                }
                else if (line[i] == ')')
                {
                    Close++;
                    Test--;
                }
            }

            if (Open == Close)
            {
                Console.WriteLine("correct");
            }
            else
            {
                Console.WriteLine("incorrect");
            }

        }

    }


}


