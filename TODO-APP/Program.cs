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

            ArgumentHandler(args, print, taskHandler);            
        }

        public static void ArgumentHandler(string[] args, Print printObj, TaskHandler taskHandlerObj)
        {
            if (args.Length == 0)
            {
                NoArgument(printObj);
            }

            else if (args[0] == "-l")
            {
                TaskLister(printObj);
            }

            else if (args[0] == "-a")
            {
                Adder(args, taskHandlerObj);
            }

            else if (args[0] == "-c")
            {
                Checker(args, taskHandlerObj);
            }

            else if (args[0] == "-r")
            {
                Remover(args, taskHandlerObj);
            }

            else if (args[0] != "-l" && args[0] != "-a" && args[0] != "-c" && args[0] != "-r")
            {
                BadArgument(printObj);
            }
        }

        public static void NoArgument(Print printObj)
        {
            printObj.WithoutArgument();
        }

        public static void BadArgument(Print printObj)
        {
            printObj.UnsupportedArgument();
        }

        public static void TaskLister(Print printObj)
        {
            printObj.ListTasks();
        }

        public static void Adder(string[] args, TaskHandler taskHandlerObj)
        {
            try
            {
                taskHandlerObj.AddTask(args[1]);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to add: no task provided");
            }
        }

        public static void Remover(string[] args, TaskHandler taskHandlerObj)
        {
            try
            {
                taskHandlerObj.RemoveTask(Convert.ToInt32(args[1]));
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Unable to remove: no index provided");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Unable to remove: index is out of bound");
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to remove: index is not a number");
            }
        }

        public static void Checker(string[] args, TaskHandler taskHandlerObj)
        {
            if (args.Length == 1)
            {
                Console.WriteLine("Unable to check: no index provided");
            }
            else
            {
                try
                {
                    taskHandlerObj.CheckTask(Convert.ToInt32(args[1]));
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Unable to check: index is out of bound");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to check: index is not a number");
                }
            }
        }
    }
}
