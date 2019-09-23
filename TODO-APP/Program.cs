using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO_APP
{
    class Program
    {
        static void Main(string[] args)
        {
            var print = new Print();
            var taskHandler = new TaskHandler();

            if (args.Length == 0)
            {

                print.WithoutArgument();
            }

            else if (args[0] == "-l")
            {
                print.ListTasks();
            }

            else if (args[0] == "-a")
            {
                taskHandler.AddTask(args[1]);
            }
        }
    }
}
