using WebHook.Functions.Models.Concrete;

namespace WebHook.Functions.Models.Interfaces
{
    public interface IWebhookSubscriptionManager
    {
        void AddSubscription(WebhookSubscription subscription);
    }
}
