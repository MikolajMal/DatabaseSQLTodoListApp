using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseSQLTodoListApp.Models
{
    public class TaskModel
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public DateTime Deadline { get; set; }
        public string Category { get; set; }
        public bool IsDone { get; set; }

        public TaskModel(string name, string category, DateTime deadline)
        {
            name = Name;
            Category = category;
            Deadline = deadline;
        }
    }
}
