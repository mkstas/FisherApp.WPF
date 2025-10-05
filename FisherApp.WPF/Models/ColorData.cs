using System.Text.Json.Serialization;
using System.Windows.Media;

namespace FisherApp.WPF.Models
{
    public class ColorData(string name, string hex)
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = name;

        [JsonPropertyName("hex")]
        public string Hex { get; set; } = hex;

        public SolidColorBrush Brush
        {
            get
            {
                return new SolidColorBrush((Color)ColorConverter.ConvertFromString(Hex));
            }
        }
    }
}
