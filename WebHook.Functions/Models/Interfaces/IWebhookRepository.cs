using System.Threading.Tasks;

namespace WebHook.Functions.Models.Interfaces
{
    public interface IWebhookRepository
    {
        Task Register();
    }
}
