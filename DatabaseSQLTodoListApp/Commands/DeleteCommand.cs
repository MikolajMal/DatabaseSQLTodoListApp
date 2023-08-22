using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using DatabaseSQLTodoListApp.ViewModel;

namespace DatabaseSQLTodoListApp.Commands
{
    class DeleteCommand : CommandBase
    {
        TodoListViewModel todoListViewModel;

        public override void Execute(object? parameter)
        {
            Debug.WriteLine("Deleting");
            todoListViewModel.DeleteTask(todoListViewModel.SelectedTask);
        }

        public DeleteCommand(TodoListViewModel todoListVM)
        {
            todoListViewModel = todoListVM;
        }
    }
}
