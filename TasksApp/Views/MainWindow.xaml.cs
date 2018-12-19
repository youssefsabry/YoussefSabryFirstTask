using System.Windows;

namespace TasksApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var xx =DataSource.GetTasks();
            int x = 0;
        }
    }
}
