using System;
using System.Collections.Generic;
using System.Linq;

class URI
{
    static void Main(string[] args)
    {

        List<Food> Foods = new List<Food>();
        Foods.Add(new Food { Name = "suco de laranja", C = 120 });
        Foods.Add(new Food { Name = "morango fresco", C = 85 });
        Foods.Add(new Food { Name = "mamao", C = 85 });
        Foods.Add(new Food { Name = "goiaba vermelha", C = 70 });
        Foods.Add(new Food { Name = "manga", C = 56 });
        Foods.Add(new Food { Name = "laranja", C = 50 });
        Foods.Add(new Food { Name = "brocolis", C = 34 });

        int Max = 130;
        int Min = 110;
        int N = 1;

        do
        {
            int Sum = 0;
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string data = Console.ReadLine();

                int qnt = int.Parse(data.Split(' ').ElementAt(0));

                int skip = qnt.ToString().Length + 1;

                string food = data.Substring(skip);

                Food food1 = Foods.First(x => x.Name == food);
                Sum += food1.C * qnt;
            }

            if(N == 0)
            {
                break;
            }
            else if (Sum > Max)
            {
                int result = Sum - Max;
                Console.WriteLine("Menos " + result + " mg");
            }
            else if (Sum < Min)
            {
                int result = Min - Sum;
                Console.WriteLine("Mais " + result + " mg");
            }
            else
            {
                Console.WriteLine(Sum + " mg");
            }
        }
        while (N > 0);

    }
    public class Food
    {
        public string Name;
        public int C;
    }

}