using System.Text.Json.Serialization;
using WebHook.Functions.Helpers;
using WebHook.Functions.Models.Interfaces;

namespace WebHook.Functions.Models.Concrete
{
    public class DiscoveryResponse : IResponse
    {
        public DiscoveryResponse()
        { }

        [JsonPropertyName("responseType")]
        public string ResponseType { get; set; }

        [JsonPropertyName("response")]
        public string Response { get; set; }

        [JsonPropertyName("responseUri")]
        public string ResponseUri { get; set; }

        [JsonPropertyName("subscriptionFormat")]
        public PropertyWrapper SubscriptionFormat { get; set; } = WebHookHelpers.SerializedPropertyList<SubscriptionRequest>();
    }
}
