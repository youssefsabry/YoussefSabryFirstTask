using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using TasksApp.ViewModels;

namespace TasksApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public VMTask VM;
        public MainWindow()
        {
            InitializeComponent();
            VM = new VMTask();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(DeadlineDayTbx.Text) <= 31 && int.Parse(DeadlineMonthTbx.Text) <= 12)
            {
                DateTime date = Convert.ToDateTime(DeadlineMonthTbx.Text + "/" + DeadlineDayTbx.Text + "/" + DeadlineYearTbx.Text);
                if (NameTbx.Text != null && date != null)
                {
                    if (date >= DateTime.Now)
                    {
                        var listTask = VM.addTask(NameTbx.Text, date);
                        DataLstBx.ItemsSource = null;
                        DataLstBx.ItemsSource = listTask;
                        NameTbx.Text = "";
                        DeadlineDayTbx.Text = "";
                        DeadlineMonthTbx.Text = "";
                        DeadlineYearTbx.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Please enter date greater than or equal date of today ");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter Name & Deadline");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid Day & Month");
            }
        }
    }
}
