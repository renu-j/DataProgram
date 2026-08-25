using System;
class program
{
    static void Main(string[] args)
    {
       int taskId = 1;
        string  description = "This is a sample task description.";
        bool isCompleted = false;
        double estimatedHours = 5.5;
        DateTime dueDate = new DateTime(2024, 12, 31);


        Console.WriteLine("Task Datails");
        Console.WriteLine("taskId: " + taskId);
        Console.WriteLine("description: " + description);
        Console.WriteLine("isCompleted: " + isCompleted);
        Console.WriteLine("estimatedHours: " + estimatedHours);
        Console.WriteLine("dueDate: " + dueDate.ToShortDateString());
    }
}
