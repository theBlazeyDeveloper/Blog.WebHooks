using System.Text.Json.Serialization;
using WebHook.Functions.Models.Interfaces;

namespace WebHook.Functions.Models.Concrete
{
    public class SubscriptionResponse : IResponse
    {
        [JsonPropertyName("response")]
        public string Response { get; set; }
    }
}
