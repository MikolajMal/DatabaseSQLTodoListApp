using DatabaseSQLTodoListApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Effects;

namespace DatabaseSQLTodoListApp.Commands
{
    internal class ShowAddTodoWindowCommand : CommandBase
    {
        Window parentWindow;
        AddTodoWindow addTodoWindow;

        public override void Execute(object? parameter)
        {
            BlurEffect blurEffect = new BlurEffect();
            blurEffect.Radius = 20;
            parentWindow.Effect = blurEffect;

            addTodoWindow = new AddTodoWindow();
            addTodoWindow.DataContext = new AddTaskViewModel(addTodoWindow);
            addTodoWindow.Owner = parentWindow;
            addTodoWindow.ShowDialog();
        }

        public ShowAddTodoWindowCommand(Window mainWindow)
        {
            parentWindow = mainWindow;
        }
    }
}
