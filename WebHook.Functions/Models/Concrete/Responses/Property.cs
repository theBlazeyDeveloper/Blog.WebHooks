using System.Text.Json.Serialization;

namespace WebHook.Functions.Models.Concrete
{
    public class Property
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
