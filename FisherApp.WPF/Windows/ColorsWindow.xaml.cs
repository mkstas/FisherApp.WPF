using FisherApp.WPF.Models;
using FisherApp.WPF.Utilites;
using System.Text.Json;
using System.Windows;

namespace FisherApp.WPF.Windows
{
    /// <summary>
    /// Interaction logic for ColorsWindow.xaml
    /// </summary>
    public partial class ColorsWindow : Window
    {
        private readonly List<Person> _people;
        public readonly List<ColorData> _colors;

        public ColorsWindow(List<Person> people)
        {
            InitializeComponent();
            DataContext = this;

            _people = people;
            _colors = GetColors();
        }

        private static List<ColorData> GetColors()
        {
            var json = FileReader.ReadJson("Resources/colors.json");

            return JsonSerializer.Deserialize<List<ColorData>>(json)!;
        }
    }
}
