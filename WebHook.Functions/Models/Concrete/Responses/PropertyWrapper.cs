using System.Text.Json.Serialization;

namespace WebHook.Functions.Models.Concrete
{
    public class PropertyWrapper
    {
        [JsonPropertyName("requestType")]
        public string RequestType { get; set; }

        [JsonPropertyName("properties")]
        public Property[] Properties { get; set; }
    }
}
