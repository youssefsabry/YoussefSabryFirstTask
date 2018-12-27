using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksApp.ViewModels
{
    public class VMTask
    {
        private List<Task> tasksList;
        public List<Task> TasksList
        {
            get { return tasksList; }
            set
            {
                if (tasksList == value) return;
                tasksList = value;
                RaisePropertyChanged("TasksList");
            }
        }

        public VMTask()
        {
            TasksList = DataSource.GetTasks();
        }

        public List<Task> addTask(string name, DateTime date)
        {
            TasksList = DataSource.GetTasks();
            int id = TasksList.Count + 1;
            TasksList.Add(new Task(id, name+"_"+id.ToString(), date));
            return TasksList;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void RaisePropertyChanged(string propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
