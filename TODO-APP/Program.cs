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

            if (args.Length == 0)
            {
                
                print.WithoutArgument();
            }

            if (args.Contains("-l"))
            {
                print.ListTasks();
            }
        }
    }
}
