using System.Text.Json.Serialization;
using WebHook.Functions.Models.Interfaces;

namespace WebHook.Functions.Models.Concrete
{
    public class SubscriptionRequest : IRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("webhookUri")]
        public string WebhookUri { get; set; }
    }
}
