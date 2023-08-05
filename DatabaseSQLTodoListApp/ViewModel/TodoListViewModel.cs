using DatabaseSQLTodoListApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSQLTodoListApp.ViewModel
{
    public class TodoListViewModel : ViewModelBase
    {
        ObservableCollection<TaskViewModel> taskViewModels;
        public IEnumerable<TaskViewModel> TaskViewModels => taskViewModels;

        public TodoListViewModel()
        {
            taskViewModels = new ObservableCollection<TaskViewModel>();

            taskViewModels.Add(new TaskViewModel(new TaskModel("Wash the dishes", "home", DateTime.Now)));
            taskViewModels.Add(new TaskViewModel(new TaskModel("Walk the dog", "home", DateTime.Now)));
            taskViewModels.Add(new TaskViewModel(new TaskModel("Clean up the basement", "home", new DateTime(2023, 09, 16, 12, 30, 0))));
        }

        public void AddTask(TaskViewModel taskViewModel)
        {
            taskViewModels.Add(taskViewModel);
        }
    }
}
