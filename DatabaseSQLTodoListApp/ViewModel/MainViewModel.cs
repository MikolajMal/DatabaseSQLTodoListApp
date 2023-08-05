using DatabaseSQLTodoListApp.Commands;
using DatabaseSQLTodoListApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DatabaseSQLTodoListApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public TodoListViewModel todoListViewModel { get; }

        public ICommand ShowAddTodoWindowCommand { get; }

        public MainViewModel(Window mainWindow)
        {
            todoListViewModel= new TodoListViewModel();

            ShowAddTodoWindowCommand = new ShowAddTodoWindowCommand(mainWindow, todoListViewModel);
        }
    }
}
