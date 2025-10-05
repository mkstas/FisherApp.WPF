using FisherApp.WPF.Models;
using FisherApp.WPF.Utilites;
using System.Text.Json;
using System.Windows;

namespace FisherApp.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Config _config;

        public App()
        {
            _config = GetConfig();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow mainWindow = new(_config);
            mainWindow.Show();
        }

        private static Config GetConfig()
        {
            var json = FileReader.ReadJson("Resources/config.default.json");

            return JsonSerializer.Deserialize<Config>(json)!;
        }
    }
}
