using DatabaseSQLTodoListApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DatabaseSQLTodoListApp.Commands
{
    internal class LoginCommand : CommandBase
    {
        Window windowToClose;
        public override void Execute(object? parameter)
        {
            PasswordBox? passwordBox = parameter as PasswordBox;

            windowToClose.Close();
        }

        public LoginCommand(Window loginWindow)
        {
            windowToClose = loginWindow;
        }
    }
}
