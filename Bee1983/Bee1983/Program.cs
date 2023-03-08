using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {


        int N = int.Parse(Console.ReadLine());
        List<Student> students = new List<Student>();
        Student Choosen = null;

        for (int i = 0; i < N; i++)
        {
            string[] Data = new string[2];

            Data = Console.ReadLine().Split(' ');

            int id = int.Parse(Data[0]);
            double note = Convert.ToDouble((Data[1]), CultureInfo.InvariantCulture);

            Student student1 = new Student(id, note);

            students.Add(student1);
        }

        List<Student> StudentsOrdered = new List<Student>(students.OrderByDescending(x => x.Note).ToList());
        Choosen = StudentsOrdered[0];

        if (Choosen.Note < 8.0)
        {
            Console.WriteLine("Minimum note not reached");
        }

        else
        {
            Console.WriteLine(Choosen.Id.ToString());
        }


    }


    public class Student
    {
        public int Id { get; set; }
        public double Note { get; set; }

        public Student(int id, double note)
        {
            Id = id;
            Note = note;

        }
    }

}