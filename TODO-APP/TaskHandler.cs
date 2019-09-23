using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TODO_APP
{
    class TaskHandler
    {
        protected string listPath = @"D:\C#\Joco456-TO-DO-APP\TODO-APP\toDoList.txt";

        public void AddTask(string task)
        {
            StreamWriter writer = new StreamWriter(listPath, true);

            writer.WriteLine(task);
            writer.Close();
        }
    }
}
