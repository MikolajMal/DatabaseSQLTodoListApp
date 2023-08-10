using DatabaseSQLTodoListApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DatabaseSQLTodoListApp.Commands
{
    internal class ExitCommand : CommandBase
    {
        Window windowToClose;
        UserLoginViewModel userLogin;
        public override void Execute(object? parameter)
        {
            windowToClose.Close();
            userLogin.CloseApp = true;
        }

        public ExitCommand(Window loginWindow, UserLoginViewModel userLoginViewModel)
        {
            windowToClose = loginWindow;
            userLogin = userLoginViewModel;
        }
    }
}
