using System.Text.Json.Serialization;

namespace FisherApp.WPF.Models
{
    public class Person(int id, int count, string color)
    {

        [JsonPropertyName("id")]
        public int Id { get; set; } = id;

        [JsonPropertyName("count")]
        public int Count { get; set; } = count;

        [JsonPropertyName("color")]
        public string Color { get; set; } = color;
    }
}
