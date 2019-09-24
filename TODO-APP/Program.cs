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
                try
                {
                    taskHandler.AddTask(args[1]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Unable to add: no task provided");
                }
            }

            else if (args[0] == "-c")
            {
                if (args.Length == 1)
                {
                    Console.WriteLine("Unable to check: no index provided");
                }
                else
                    try
                    {
                        taskHandler.CheckTask(Convert.ToInt32(args[1]));
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

            else if (args[0] == "-r")
            {
                try
                {
                    taskHandler.RemoveTask(Convert.ToInt32(args[1]));
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

            else if (args[0] != "-l" && args[0] != "-a" && args[0] != "-c" && args[0] != "-r")
            {
                print.UnsupportedArgument();
            }
        }
    }
}
