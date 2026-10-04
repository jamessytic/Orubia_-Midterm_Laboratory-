using System;
using System.Collections.Generic;

struct Operation
{
    public string Action;
    public string StudentNumber;
    public string StudentName;
}

class Program
{
    static void Main()
    {
        Stack<Operation> operationHistory =
            new Stack<Operation>();

        int choice;

        do
        {
            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("          OPERATION HISTORY");
            Console.WriteLine("========================================");
            Console.WriteLine();
            Console.WriteLine("1. Record Operation");
            Console.WriteLine("2. View Operation History");
            Console.WriteLine("3. View Last Operation");
            Console.WriteLine("4. Remove Last Operation");
            Console.WriteLine("5. Exit");
            Console.WriteLine();

            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (choice == 1)
            {
                Operation operation = new Operation();

                Console.Write("Enter Action: ");
                operation.Action = Console.ReadLine();

                Console.Write("Enter Student Number: ");
                operation.StudentNumber = Console.ReadLine();

                Console.Write("Enter Student Name: ");
                operation.StudentName = Console.ReadLine();

                operationHistory.Push(operation);

                Console.WriteLine();
                Console.WriteLine("Operation recorded successfully!");
            }
            else if (choice == 2)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("          OPERATION HISTORY");
                Console.WriteLine("========================================");

                if (operationHistory.Count == 0)
                {
                    Console.WriteLine("No operations recorded.");
                }
                else
                {
                    int number = 1;

                    foreach (Operation operation in operationHistory)
                    {
                        Console.WriteLine(
                            number + ". " +
                            operation.Action + " " +
                            operation.StudentName);

                        number++;
                    }
                }
            }
            else if (choice == 3)
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine("No operations recorded.");
                }
                else
                {
                    Operation operation = operationHistory.Peek();

                    Console.WriteLine(
                        "Last Operation: " +
                        operation.Action + " " +
                        operation.StudentName);
                }
            }
            else if (choice == 4)
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine("No operations to remove.");
                }
                else
                {
                    operationHistory.Pop();

                    Console.WriteLine(
                        "Last operation removed successfully!");
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("Program exited.");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            if (choice != 5)
            {
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }

        } while (choice != 5);
    }
}