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
            if (args.Length == 0)
            {
                var print = new Print();
                print.WithoutArgument();
            }         
        }
    }
}
