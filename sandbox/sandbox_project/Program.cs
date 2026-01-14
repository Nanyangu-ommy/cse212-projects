using System;

public class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> student = new Dictionary<string, int>();
        {
            student["Alice"] = 90;
            student["Bob"] = 85;
            student["Charlie"] = 92;
            student["Diana"] = 88;
            student["Ethan"] = 95;
        };
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        Console.WriteLine("student list");

        foreach (var entry in student)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}