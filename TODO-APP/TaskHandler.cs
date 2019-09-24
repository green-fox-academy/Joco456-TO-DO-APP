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
        string listPath = @"D:\C#\Joco456-TO-DO-APP\TODO-APP\toDoList.txt";

        public void AddTask(string task)
        {
            StreamWriter writer = new StreamWriter(listPath, true);

            writer.WriteLine("[ ] " + task);
            writer.Close();
        }

        public void CheckTask(int number)
        {         
            string[] content = File.ReadAllLines(listPath);

            content[number - 1] = content[number - 1].Replace("[ ]", "[X]");           

            File.WriteAllLines(listPath, content);         
        }

        public void RemoveTask(int number)
        {
            List<string> toDoList = new List<string>();

            string[] content = File.ReadAllLines(listPath);

            toDoList.AddRange(content);

            toDoList.Remove(toDoList[number - 1]);

            File.WriteAllLines(listPath, toDoList);
        }        
    }
}
