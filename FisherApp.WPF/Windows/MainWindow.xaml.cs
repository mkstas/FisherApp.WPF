using FisherApp.WPF.Models;
using FisherApp.WPF.Windows;
using Microsoft.Win32;
using System.IO;
using System.Text.Json;
using System.Windows;

namespace FisherApp.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Config _config;
        private readonly List<Person> _people;
        private bool IsStarted { get; set; } = false;
        private bool IsPaused { get; set; } = false;

        public MainWindow(Config config)
        {
            InitializeComponent();

            _config = config;
            _people = config.People;

            startBtn.Content = IsStarted ? "Стоп" : "Старт";
            pauseBtn.Content = IsPaused ? "Продолжить" : "Пауза";
        }

        private void OpenMenuFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "JSON files (*.json)|*.json"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string jsonString = File.ReadAllText(openFileDialog.FileName);
                var json = JsonDocument.Parse(jsonString).RootElement;

                _config.Speed = json.GetProperty("speed").GetInt32();
                _config.Alarm = json.GetProperty("alarm").GetInt32();
                _config.People = json.GetProperty("people").Deserialize<List<Person>>()!;
            }
        }

        private void SaveMenuFile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OpenColorsWindow_Click(object sender, RoutedEventArgs e)
        {
            ColorsWindow colorsWindow = new(_people);
            colorsWindow.ShowDialog();
        }

        private void OpenInitialWindow_Click(object sender, RoutedEventArgs e)
        {
            //InitialWindow initialWindow = new();
            //initialWindow.ShowDialog();
        }

        private void OpenAboutWindow_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow aboutWindow = new();
            aboutWindow.ShowDialog();
        }

        private void OpenAuthorWindow_Click(object sender, RoutedEventArgs e)
        {
            AuthorWindow authorWindow = new();
            authorWindow.ShowDialog();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            IsStarted = !IsStarted;
            startBtn.Content = IsStarted ? "Стоп" : "Старт";
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            IsPaused = !IsPaused;
            pauseBtn.Content = IsPaused ? "Продолжить" : "Пауза";
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
