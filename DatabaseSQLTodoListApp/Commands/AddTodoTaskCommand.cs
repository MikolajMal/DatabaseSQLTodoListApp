using DatabaseSQLTodoListApp.Models;
using DatabaseSQLTodoListApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSQLTodoListApp.Commands
{
    internal class AddTodoTaskCommand : CommandBase
    {
        TodoListViewModel todoListViewModel;
        AddTaskViewModel addTaskViewModel;
        public override void Execute(object? parameter)
        {
            todoListViewModel.AddTask(new TaskViewModel(new TaskModel("Walk the dog", "home", DateTime.Now)));
        }

        public AddTodoTaskCommand(TodoListViewModel originalTodoListViewModel, AddTaskViewModel originalAddTaskViewModel)
        {
            todoListViewModel = originalTodoListViewModel;
            addTaskViewModel = originalAddTaskViewModel;
        }
    }
}
