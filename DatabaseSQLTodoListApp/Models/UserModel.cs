using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSQLTodoListApp.Models
{
    internal class UserModel
    {
        public string Password { get; set; }

        public UserModel(string password)
        {
            Password = password;
        }
    }
}
