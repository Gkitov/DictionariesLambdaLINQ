using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

        int n = int.Parse(Console.ReadLine());

        // Reading the student's name and grade pairs
        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());

            if (!students.ContainsKey(name))
            {
                students[name] = new List<double>();
            }

            students[name].Add(grade);
        }

        // Filtering students with average grade >= 4.50
        students = students.Where(s => s.Value.Average() >= 4.50).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

        // Printing students and their average grades
        foreach (var student in students.OrderByDescending(s => s.Value.Average()))
        {
            Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
        }
    }
}
