using System.Text;
using System.Collections.Generic;
using System.Linq;

List<Duende> Data = new List<Duende>();

int InNumber = int.Parse(Console.ReadLine());
int TeamsNumber = InNumber / 3;

for (int i = 0; i < InNumber; i++)
{
    string duende = Console.ReadLine();
    string[] duendeArray = duende.Split(' ');

    Duende d1 = new Duende(duendeArray[0], int.Parse(duendeArray[1]));
    Data.Add(d1);
}

List<Duende> Duendes = new List<Duende>(Data.OrderByDescending(x => x.Age).ThenBy(x => x.Name));

for (int i = 0; i < TeamsNumber; i++)
{
    Console.WriteLine("Time " + (i + 1));
    Console.WriteLine(Duendes[i].ToString());
    Console.WriteLine(Duendes[i + TeamsNumber].ToString());
    Console.WriteLine(Duendes[i + TeamsNumber * 2].ToString());
    Console.WriteLine();
}

public class Duende
{
    public string Name;
    public int Age;

    public Duende(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return Name + " " + Age;
    }
}