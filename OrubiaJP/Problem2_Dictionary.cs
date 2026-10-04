using System;
using System.Collections.Generic;

struct Student
{
    public string StudentNumber;
    public string Name;
    public string Program;
    public int YearLevel;
}

class Program
{
    static void Main()
    {
        Dictionary<string, Student> studentDictionary =
            new Dictionary<string, Student>();

        int choice;

        do
        {
            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("      STUDENT LOOKUP USING DICTIONARY");
            Console.WriteLine("========================================");
            Console.WriteLine();
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Search Student");
            Console.WriteLine("3. Display All Students");
            Console.WriteLine("4. Exit");
            Console.WriteLine();

            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (choice == 1)
            {
                Console.Write("Enter Student Number: ");
                string studentNumber = Console.ReadLine();

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Program: ");
                string program = Console.ReadLine();

                Console.Write("Enter Year Level: ");
                int yearLevel = int.Parse(Console.ReadLine());

                Student student = new Student();

                student.StudentNumber = studentNumber;
                student.Name = name;
                student.Program = program;
                student.YearLevel = yearLevel;

                studentDictionary[studentNumber] = student;

                Console.WriteLine();
                Console.WriteLine("Student added successfully!");
            }
            else if (choice == 2)
            {
                Console.Write("Enter Student Number to search: ");
                string searchNumber = Console.ReadLine();

                if (studentDictionary.ContainsKey(searchNumber))
                {
                    Student student = studentDictionary[searchNumber];

                    Console.WriteLine();
                    Console.WriteLine("Student Found!");
                    Console.WriteLine("Student Number: " + student.StudentNumber);
                    Console.WriteLine("Name: " + student.Name);
                    Console.WriteLine("Program: " + student.Program);
                    Console.WriteLine("Year Level: " + student.YearLevel);
                }
                else
                {
                    Console.WriteLine("Student Number does not exist.");
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("           STUDENT RECORDS");
                Console.WriteLine("========================================");

                if (studentDictionary.Count == 0)
                {
                    Console.WriteLine("No student records found.");
                }
                else
                {
                    foreach (KeyValuePair<string, Student> item in studentDictionary)
                    {
                        Student student = item.Value;

                        Console.WriteLine();
                        Console.WriteLine("Student Number: " + student.StudentNumber);
                        Console.WriteLine("Name: " + student.Name);
                        Console.WriteLine("Program: " + student.Program);
                        Console.WriteLine("Year Level: " + student.YearLevel);
                    }
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("Program exited.");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            if (choice != 4)
            {
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }

        } while (choice != 4);
    }
}