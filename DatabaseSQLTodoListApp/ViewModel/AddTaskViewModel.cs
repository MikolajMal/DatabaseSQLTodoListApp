using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public ICommand AddCommand { get; }
        public ICommand CancelCommand { get; }

        public AddTaskViewModel()
        {

        }
    }
}
