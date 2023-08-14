using DatabaseSQLTodoListApp.Models;
using DatabaseSQLTodoListApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DatabaseSQLTodoListApp.Commands
{
    internal class AddTodoTaskCommand : CommandBase
    {
        TodoListViewModel todoListViewModel;
        AddTaskViewModel addTaskViewModel;
        Window windowToClose;
        public override void Execute(object? parameter)
        {
            todoListViewModel.AddTask(new TaskViewModel(new TaskModel(addTaskViewModel.TaskName, addTaskViewModel.CurrentCategory.ToString(), addTaskViewModel.Deadline)));

            windowToClose.Owner.Effect = null;
            windowToClose.Close();
        }

        public AddTodoTaskCommand(TodoListViewModel originalTodoListViewModel, AddTaskViewModel originalAddTaskViewModel, Window dialogWindow)
        {
            todoListViewModel = originalTodoListViewModel;
            addTaskViewModel = originalAddTaskViewModel;
            windowToClose = dialogWindow;
        }
    }
}
