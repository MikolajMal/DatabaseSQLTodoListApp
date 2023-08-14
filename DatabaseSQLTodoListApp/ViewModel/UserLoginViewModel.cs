using DatabaseSQLTodoListApp.Commands;
using DatabaseSQLTodoListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DatabaseSQLTodoListApp.ViewModel
{
    internal class UserLoginViewModel : ViewModelBase
    {
        public string ConnectionString { get; set; }

        Visibility wrongPasswordInfoVisibility = Visibility.Hidden;
        public Visibility WrongPasswordInfoVisibility
        {
            get => wrongPasswordInfoVisibility;
            set
            {
                wrongPasswordInfoVisibility = value;
                OnPropertyChanged(nameof(WrongPasswordInfoVisibility));
            }
        }

        public bool CloseApp { get; set; }

        public ICommand LoginCommand { get; }
        public ICommand ExitCommand { get; }

        public UserLoginViewModel(Window loginWindow)
        {
            CloseApp = false;

            LoginCommand = new LoginCommand(loginWindow, this);
            ExitCommand = new ExitCommand(loginWindow, this);
        }
    }
}
