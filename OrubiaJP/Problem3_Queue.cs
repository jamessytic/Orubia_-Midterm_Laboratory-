using System;
using System.Collections.Generic;

struct StudentRequest
{
    public string StudentNumber;
    public string StudentName;
    public string RequestType;
}

class Program
{
    static void Main()
    {
        Queue<StudentRequest> requestQueue =
            new Queue<StudentRequest>();

        int choice;

        do
        {
            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("        STUDENT REQUEST QUEUE");
            Console.WriteLine("========================================");
            Console.WriteLine();
            Console.WriteLine("1. Add Request");
            Console.WriteLine("2. View Pending Requests");
            Console.WriteLine("3. Process Request");
            Console.WriteLine("4. Exit");
            Console.WriteLine();

            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (choice == 1)
            {
                StudentRequest request = new StudentRequest();

                Console.Write("Enter Student Number: ");
                request.StudentNumber = Console.ReadLine();

                Console.Write("Enter Student Name: ");
                request.StudentName = Console.ReadLine();

                Console.Write("Enter Request Type: ");
                request.RequestType = Console.ReadLine();

                requestQueue.Enqueue(request);

                Console.WriteLine();
                Console.WriteLine("Request added successfully!");
            }
            else if (choice == 2)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("            REQUEST QUEUE");
                Console.WriteLine("========================================");

                if (requestQueue.Count == 0)
                {
                    Console.WriteLine("No pending requests.");
                }
                else
                {
                    int number = 1;

                    foreach (StudentRequest request in requestQueue)
                    {
                        Console.WriteLine(
                            number + ". " +
                            request.StudentName + " - " +
                            request.RequestType);

                        number++;
                    }
                }
            }
            else if (choice == 3)
            {
                if (requestQueue.Count == 0)
                {
                    Console.WriteLine("No requests to process.");
                }
                else
                {
                    StudentRequest request = requestQueue.Dequeue();

                    Console.WriteLine(
                        "Processing Request: " +
                        request.StudentName + " - " +
                        request.RequestType);

                    Console.WriteLine();
                    Console.WriteLine("Request processed successfully!");
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