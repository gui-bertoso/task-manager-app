using System.Collections.ObjectModel;
using Avalonia.Controls;

namespace CSTaskManager
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<TaskItem> tasks = new ObservableCollection<TaskItem>();

        public MainWindow()
        {
            InitializeComponent();
            TasksListBox.ItemsSource = tasks;
        }

        private void AddTask_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TaskNameInput.Text) && !string.IsNullOrWhiteSpace(TaskDescriptionInput.Text))
            {
                tasks.Add(new TaskItem
                    {
                        Name = TaskNameInput.Text,
                        Description = TaskDescriptionInput.Text
                    }
                );
                TaskNameInput.Text = "";
                TaskDescriptionInput.Text = "";
            }
        }
    }
}