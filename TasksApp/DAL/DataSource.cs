using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksApp
{
    public class DataSource
    {
        public static List<Task> GetTasks()
        {
            List<Task> tasks = new List<Task>();
            for (int i = 1; i <= 8; i++)
            {
                string name = "Task_" + i.ToString();
                DateTime date = DateTime.Now.AddDays(-i);
                Task newTask = new Task(i, name, date);
                tasks.Add(newTask);
            }
            return tasks;
        }
    }
}
