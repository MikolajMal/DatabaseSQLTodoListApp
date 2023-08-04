using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DatabaseSQLTodoListApp.Commands
{
    internal class CancelCommand : CommandBase
    {
        Window windowToClose;
        public override void Execute(object? parameter)
        {
            windowToClose.Owner.Effect = null;
            windowToClose.Close();
        }

        public CancelCommand(Window dialogWindow)
        {
            windowToClose = dialogWindow;
        }
    }
}
