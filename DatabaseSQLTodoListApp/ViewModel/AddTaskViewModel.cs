using DatabaseSQLTodoListApp.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DatabaseSQLTodoListApp.ViewModel
{
    public enum Category { home, work, hobby, sport, learning, other }
    public class AddTaskViewModel : ViewModelBase
    {
        string taskName;
        public string TaskName
        {
            get => taskName;
            set
            {
                taskName = value;
                OnPropertyChanged(nameof(TaskName));
                OnPropertyChanged(nameof(CanAdd));
            }
        }

        DateTime deadline;
        public DateTime Deadline
        {
            get => deadline;
            set
            {
                deadline = value;
                OnPropertyChanged(nameof(Deadline));
            }
        }


        Category category;
        public Category CurrentCategory
        {
            get => category;
            set
            {
                category = value;
                OnPropertyChanged(nameof(CurrentCategory));
            }
        }

        public bool CanAdd => !string.IsNullOrEmpty(taskName);

        public ICommand AddCommand { get; }
        public ICommand CancelCommand { get; }

        public AddTaskViewModel(Window addTodoWindow)
        {
            CancelCommand = new CancelCommand(addTodoWindow);

            TaskName = "Default Name";
            Deadline = DateTime.Now;
        }
    }
}
