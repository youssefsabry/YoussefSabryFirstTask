﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksApp
{
    public class Task
    {
        //Read-Only
        public int ID { get; private set; }
        public string TaskName { get; set; }
        public DateTime CreatedAt { get; set; }

        public Task(int id,string name,DateTime time)
        {
            this.ID = id;
            this.CreatedAt = time;
            this.TaskName = name;
        }
    }
}
