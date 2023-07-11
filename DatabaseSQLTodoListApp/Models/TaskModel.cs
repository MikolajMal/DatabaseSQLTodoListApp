using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseSQLTodoListApp.Models
{
    class TaskModel
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string Deadline { get; set; }
        public bool IsDone { get; set; }
    }
}
