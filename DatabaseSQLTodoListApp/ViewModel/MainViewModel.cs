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

        //readonly ObservableCollection<TaskViewModel> tasks;
        //public IEnumerable<TaskViewModel> Tasks => tasks;

        public ICommand ShowAddTodoWindowCommand { get; }

        public MainViewModel(Window mainWindow)
        {
            todoListViewModel= new TodoListViewModel();

            ShowAddTodoWindowCommand = new ShowAddTodoWindowCommand(mainWindow);

            //tasks = new ObservableCollection<TaskViewModel>();

            //tasks.Add(new TaskViewModel(new TaskModel("Wash the dishes", "home", DateTime.Now)));
            //tasks.Add(new TaskViewModel(new TaskModel("Walk the dog", "home", DateTime.Now)));
            //tasks.Add(new TaskViewModel(new TaskModel("Clean up the basement", "home", new DateTime(2023, 09, 16, 12, 30, 0))));
        }
    }
}
