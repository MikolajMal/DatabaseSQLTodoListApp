using DatabaseSQLTodoListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DatabaseSQLTodoListApp.ViewModel
{
    public class TaskViewModel : ViewModelBase
    {
        TaskModel taskModel;

        public string? Name => taskModel.Name;
        public DateTime Deadline => taskModel.Deadline;
        public string Category => taskModel.Category;

        public ICommand EditCommand;
        public ICommand DeleteCommand;
        

        public TaskViewModel(TaskModel _taskModel)
        {
            taskModel = _taskModel;
        }
    }
}
