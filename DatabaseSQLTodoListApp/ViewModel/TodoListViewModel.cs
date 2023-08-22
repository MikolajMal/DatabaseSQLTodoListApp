using DatabaseSQLTodoListApp.Models;
using MySql.Data.MySqlClient;
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

        TaskViewModel selectedTask;
        public TaskViewModel SelectedTask
        {
            get { return selectedTask; }
            set
            {
                if (selectedTask != value)
                {
                    selectedTask = value;
                    OnPropertyChanged(nameof(SelectedTask));
                }
            }
        }


        public string ConnectionString { private get; set; }

        public ObservableCollection<TaskViewModel> GetAllTasks()
        {
            ObservableCollection<TaskViewModel> tasks = new ObservableCollection<TaskViewModel>();

            MySqlConnection connection = new MySqlConnection(ConnectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT task,category,deadline FROM tasks", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    TaskViewModel taskVM = new TaskViewModel(
                        new TaskModel(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetDateTime(2)));

                    tasks.Add(taskVM);
                }
            }

            connection.Close();

            return tasks;
        }

        public TodoListViewModel(string connectionString)
        {
            taskViewModels = new ObservableCollection<TaskViewModel>();

            //taskViewModels.Add(new TaskViewModel(new TaskModel("Wash the dishes", "home", DateTime.Now)));
            //taskViewModels.Add(new TaskViewModel(new TaskModel("Walk the dog", "home", DateTime.Now)));
            //taskViewModels.Add(new TaskViewModel(new TaskModel("Clean up the basement", "home", new DateTime(2023, 09, 16, 12, 30, 0))));

            ConnectionString = connectionString;

            taskViewModels = GetAllTasks();
        }

        public void AddTask(TaskViewModel taskViewModel)
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);

            connection.Open();

            string commandString = "INSERT INTO tasks (task,deadline,is_done,category) VALUES (@task_name,@deadline,'NO',@category)";

            MySqlCommand command = new MySqlCommand(commandString, connection);

            command.Parameters.AddWithValue("@task_name", taskViewModel.Name);
            command.Parameters.AddWithValue("@deadline", taskViewModel.Deadline);
            command.Parameters.AddWithValue("@category", taskViewModel.Category);

            command.ExecuteNonQuery();

            connection.Close();

            taskViewModels = GetAllTasks();
            
            OnPropertyChanged(nameof(taskViewModels));
        }

        public void DeleteTask(TaskViewModel taskViewModel)
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);

            connection.Open();

            string commandString = "DELETE FROM tasks WHERE task = @task_name";

            MySqlCommand command = new MySqlCommand(commandString, connection);

            command.Parameters.AddWithValue("@task_name", taskViewModel.Name);

            command.ExecuteNonQuery();

            connection.Close();

            taskViewModels = GetAllTasks();

            OnPropertyChanged(nameof(taskViewModels));
        }
    }
}
