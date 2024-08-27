using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    internal class main
    {
        static List<TaskItem> tasks = new List<TaskItem>();

        static void Main(String[] args)
        {
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("To-Do List:");
                    Console.WriteLine("1. Add Task");
                    Console.WriteLine("2. View Tasks");
                    Console.WriteLine("3. Complete Task");
                    Console.WriteLine("4. Remove Task");
                    Console.WriteLine("5. Exit");
                    Console.Write("Choose an option: ");
                    var choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            AddTask();
                            break;
                        case "2":
                            ViewTasks();
                            break;
                        case "3":
                            CompleteTask();
                            break;
                        case "4":
                            RemoveTask();
                            break;
                        case "5":
                            Console.WriteLine("Exiting the application. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }

                    Console.WriteLine("Press any key to return to the menu...");
                    Console.ReadKey();
                }
            }
        }

        static void AddTask()
        {
            Console.Write("Enter task title: ");
            var title = Console.ReadLine();
            tasks.Add(new TaskItem(title));
            Console.WriteLine("Task added.");
        }

        static void ViewTasks()
        {
            Console.WriteLine("Tasks:");
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found.");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    var status = tasks[i].IsCompleted ? "Completed" : "Pending";
                    Console.WriteLine($"{i + 1}. {tasks[i].Title} - {status}");
                }
            }
        }

        static void CompleteTask()
        {
            ViewTasks();
            Console.Write("Enter the number of the task to mark as completed: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber <= tasks.Count && taskNumber > 0)
            {
                tasks[taskNumber - 1].IsCompleted = true;
                Console.WriteLine("Task marked as completed.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }

        static void RemoveTask()
        {
            ViewTasks();
            Console.Write("Enter the number of the task to remove: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber <= tasks.Count && taskNumber > 0)
            {
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Task removed.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
    }
}
