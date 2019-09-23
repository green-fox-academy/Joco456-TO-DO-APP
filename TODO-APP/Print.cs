using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TODO_APP
{
    class Print
    {
        protected string[] arguments = {
            "-l   Lists all the tasks",
            "-a   Adds a new task",
            "-r   Removes a task",
            "-c   Completes a task" };

        protected string[] ToDoList = File.ReadAllLines(@"D:\C#\Joco456-TO-DO-APP\TODO-APP\toDoList.txt");

        public void WithoutArgument()
        {
            Console.WriteLine("\nCommand Line Todo application");
            Console.WriteLine("=============================\n");
            Console.WriteLine("Command line arguments:");

            for (int i = 0; i < arguments.Length; i++)
            {
                Console.WriteLine("\t" + arguments[i]);
            }
        }

        public void ListTasks()
        {
            if (!(ToDoList.Length > 0))
            {
                Console.WriteLine("No todos for today! :)");
            }
            else
            {
                for (int i = 0; i < ToDoList.Length; i++)
                {
                    Console.WriteLine((i + 1) + " - " + ToDoList[i]);
                }
            }
        }

        public void CheckTask(int index)
        {
            Console.WriteLine("The task Nr. " + index + " is: " + ToDoList[index - 1]);
        }
    }
}
