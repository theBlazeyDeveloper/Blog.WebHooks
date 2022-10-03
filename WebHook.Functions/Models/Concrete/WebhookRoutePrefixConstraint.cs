using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using WebHook.Functions.Options;

namespace WebHook.Functions.Models.Concrete
{
    public class WebhookRoutePrefixConstraint : IRouteConstraint
    {        
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (values.TryGetValue("prefix", out var value) && value is string actual)
            {
                var options = httpContext
                    .RequestServices
                    .GetRequiredService<IOptions<WebhookOptions>>();
                
                return options.Value.RoutePrefix == actual;
            }
            return false;
        }
    }
}
