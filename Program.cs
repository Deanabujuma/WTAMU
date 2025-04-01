using System;
using System.Collections.Generic;

class Student
{
    private int studentID;
    private string studentName;
    public static List<Student> studentList = new List<Student>();

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"ID: {studentID}, Name: {studentName}");
    }

    public string GetName()
    {
        return studentName;
    }
}

class Program
{
    static void Main()
    {
        // Creating students
        new Student(111, "Alice");
        new Student(222, "Bob");
        new Student(333, "Cathy");
        new Student(444, "David");

        // Creating gradebook dictionary
        Dictionary<string, double> gradebook = new Dictionary<string, double>
        {
            {"Alice", 4.0},
            {"Bob", 3.6},
            {"Cathy", 2.5},
            {"David", 1.8}
        };

        // Checking and adding Tom if not present
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook["Tom"] = 3.3;
        }

        // Calculating average GPA
        double totalGPA = 0;
        foreach (var gpa in gradebook.Values)
        {
            totalGPA += gpa;
        }
        double averageGPA = totalGPA / gradebook.Count;
        Console.WriteLine($"Average GPA: {averageGPA:F2}");

        // Printing students with GPA above average
        Console.WriteLine("Students with GPA above average:");
        foreach (var student in Student.studentList)
        {
            if (gradebook.ContainsKey(student.GetName()) && gradebook[student.GetName()] > averageGPA)
            {
                student.PrintInfo();
            }
        }
    }
}
