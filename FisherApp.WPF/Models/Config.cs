using System.Text.Json.Serialization;

namespace FisherApp.WPF.Models
{
    public class Config
    {
        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("alarm")]
        public int Alarm { get; set; }

        [JsonPropertyName("people")]
        public List<Person> People { get; set; } = [];
    }
}
