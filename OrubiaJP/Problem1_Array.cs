using System;

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
        Student[] students = new Student[10];
        int studentCount = 0;
        int choice;

        do
        {
            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("       STUDENT RECORD MANAGEMENT");
            Console.WriteLine("========================================");
            Console.WriteLine();
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display All Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Exit");
            Console.WriteLine();

            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (choice == 1)
            {
                if (studentCount >= 10)
                {
                    Console.WriteLine("Cannot add more than 10 students.");
                }
                else
                {
                    Console.Write("Enter Student Number: ");
                    students[studentCount].StudentNumber = Console.ReadLine();

                    Console.Write("Enter Name: ");
                    students[studentCount].Name = Console.ReadLine();

                    Console.Write("Enter Program: ");
                    students[studentCount].Program = Console.ReadLine();

                    Console.Write("Enter Year Level: ");
                    students[studentCount].YearLevel =
                        int.Parse(Console.ReadLine());

                    studentCount++;

                    Console.WriteLine();
                    Console.WriteLine("Student added successfully!");
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("           STUDENT RECORDS");
                Console.WriteLine("========================================");

                if (studentCount == 0)
                {
                    Console.WriteLine("No student records found.");
                }
                else
                {
                    for (int i = 0; i < studentCount; i++)
                    {
                        Console.WriteLine();
                        Console.WriteLine(
                            "Student Number: " +
                            students[i].StudentNumber);

                        Console.WriteLine(
                            "Name: " +
                            students[i].Name);

                        Console.WriteLine(
                            "Program: " +
                            students[i].Program);

                        Console.WriteLine(
                            "Year Level: " +
                            students[i].YearLevel);
                    }
                }
            }
            else if (choice == 3)
            {
                Console.Write("Enter Student Number to search: ");
                string searchNumber = Console.ReadLine();

                bool found = false;

                for (int i = 0; i < studentCount; i++)
                {
                    if (students[i].StudentNumber == searchNumber)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Student Found!");

                        Console.WriteLine(
                            "Student Number: " +
                            students[i].StudentNumber);

                        Console.WriteLine(
                            "Name: " +
                            students[i].Name);

                        Console.WriteLine(
                            "Program: " +
                            students[i].Program);

                        Console.WriteLine(
                            "Year Level: " +
                            students[i].YearLevel);

                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Student not found.");
                }
            }
            else if (choice == 4)
            {
                Console.Write("Enter Student Number to update: ");
                string searchNumber = Console.ReadLine();

                bool found = false;

                for (int i = 0; i < studentCount; i++)
                {
                    if (students[i].StudentNumber == searchNumber)
                    {
                        Console.Write("Enter New Name: ");
                        students[i].Name = Console.ReadLine();

                        Console.Write("Enter New Program: ");
                        students[i].Program = Console.ReadLine();

                        Console.Write("Enter New Year Level: ");
                        students[i].YearLevel =
                            int.Parse(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine(
                            "Student updated successfully!");

                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Student not found.");
                }
            }
            else if (choice == 5)
            {
                Console.Write("Enter Student Number to delete: ");
                string searchNumber = Console.ReadLine();

                int index = -1;

                for (int i = 0; i < studentCount; i++)
                {
                    if (students[i].StudentNumber == searchNumber)
                    {
                        index = i;
                        break;
                    }
                }

                if (index == -1)
                {
                    Console.WriteLine("Student not found.");
                }
                else
                {
                    for (int i = index; i < studentCount - 1; i++)
                    {
                        students[i] = students[i + 1];
                    }

                    studentCount--;

                    Console.WriteLine();
                    Console.WriteLine(
                        "Student deleted successfully!");
                }
            }
            else if (choice == 6)
            {
                Console.WriteLine("Program exited.");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            if (choice != 6)
            {
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }

        } while (choice != 6);
    }
}