using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO_APP
{
    class Print
    {
        string[] arguments = {
            "-l   Lists all the tasks",
            "-a   Adds a new task",
            "-r   Removes a task",
            "-c   Completes a task" };

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
    }
}
