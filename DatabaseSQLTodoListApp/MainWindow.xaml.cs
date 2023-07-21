using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DatabaseSQLTodoListApp.Views;
using DatabaseSQLTodoListApp.ViewModel;

namespace DatabaseSQLTodoListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AddTodoWindow addTodoWindow;
        //Window window = new Window
        //{
        //    Title = "Add todo task",
        //    Content = new AddTodoWindow(),
        //    SizeToContent = SizeToContent.WidthAndHeight,
        //    WindowStyle = WindowStyle.None,
        //    AllowsTransparency= true,
        //};

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //window.MouseDown += Window_MouseDown;
            //window.ShowDialog();
            addTodoWindow = new AddTodoWindow();
            addTodoWindow.MouseDown += Window_MouseDown;
            addTodoWindow.ShowDialog();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //if (e.ChangedButton == MouseButton.Left)
            //    window.DragMove();
            if (e.ChangedButton == MouseButton.Left)
                addTodoWindow.DragMove();

        }
    }
}
