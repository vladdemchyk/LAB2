// This program demonstrates the use of lambda expressions in C# for filtering, sorting, grouping and creating delegates

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Read data from a file or database
        List<Student> students = new List<Student>
        {
            new Student { Name = "John", Grade = 90 },
            new Student { Name = "Jane", Grade = 85 },
            new Student { Name = "Bob", Grade = 75 },
            new Student { Name = "Alice", Grade = 95 },
            new Student { Name = "Tom", Grade = 80 }
        };

        // Filter students by grade using lambda expression
        var filteredStudents = students.Where(s => s.Grade >= 85);

        // Sort students by grade using lambda expression
        var sortedStudents = students.OrderByDescending(s => s.Grade);

        // Group students by grade using lambda expression
        var groupedStudents = students.GroupBy(s => s.Grade);

        // Create a delegate using lambda expression
        Func<string, int> stringLength = s => s.Length;

        // Process a list of strings using the delegate
        List<string> strings = new List<string> { "hello", "world", "lambda", "expression" };
        var stringLengths = strings.Select(stringLength);

        // Print the results
        Console.WriteLine("Filtered students:");
        foreach (var student in filteredStudents)
        {
            Console.WriteLine($"{student.Name} - {student.Grade}");
        }

        Console.WriteLine("\nSorted students:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"{student.Name} - {student.Grade}");
        }

        Console.WriteLine("\nGrouped students:");
        foreach (var group in groupedStudents)
        {
            Console.WriteLine($"Grade: {group.Key}");
            foreach (var student in group)
            {
                Console.WriteLine($"- {student.Name}");
            }
        }

        Console.WriteLine("\nString lengths:");
        foreach (var length in stringLengths)
        {
            Console.WriteLine(length);
        }
    }
}

class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
}
