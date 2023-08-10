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
        UserViewModel userViewModel;

        public string Password { get; set; }

        public bool CloseApp { get; set; }

        public ICommand LoginCommand { get; }
        public ICommand ExitCommand { get; }

        public UserLoginViewModel(Window loginWindow)
        {
            CloseApp = false;

            userViewModel = new UserViewModel(new UserModel("123"));

            LoginCommand = new LoginCommand(loginWindow);
            ExitCommand = new ExitCommand(loginWindow, this);
        }
    }
}
