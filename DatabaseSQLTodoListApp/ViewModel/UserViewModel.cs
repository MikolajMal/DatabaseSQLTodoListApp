using DatabaseSQLTodoListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSQLTodoListApp.ViewModel
{
    internal class UserViewModel
    {
        UserModel user;

        public string Password => user.Password;

        public UserViewModel(UserModel userModel)
        {
            user = userModel;
        }
    }
}
