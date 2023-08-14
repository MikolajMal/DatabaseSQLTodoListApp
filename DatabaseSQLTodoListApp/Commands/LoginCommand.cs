using DatabaseSQLTodoListApp.Models;
using DatabaseSQLTodoListApp.ViewModel;
using MySql.Data.MySqlClient;
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
        UserLoginViewModel userLoginViewModel;

        public override void Execute(object? parameter)
        {
            PasswordBox? passwordBox = parameter as PasswordBox;

            if (passwordBox == null) return;

            string connectionString = $"datasource=localhost;port=3306;username=root;password={passwordBox.Password};database=todolistapp";

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                passwordBox.Password = "";
                userLoginViewModel.WrongPasswordInfoVisibility = Visibility.Visible;
                return;
            }

            userLoginViewModel.ConnectionString = connectionString;

            windowToClose.Close();

            connection.Close();
        }

        public LoginCommand(Window loginWindow, UserLoginViewModel userLoginVM)
        {
            windowToClose = loginWindow;
            userLoginViewModel = userLoginVM;
        }
    }
}
