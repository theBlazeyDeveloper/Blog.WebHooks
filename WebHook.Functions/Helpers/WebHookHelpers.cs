using System.Collections.Generic;
using System.Linq;
using WebHook.Functions.Models.Concrete;

namespace WebHook.Functions.Helpers
{
    public static class WebHookHelpers
    {
        public static PropertyWrapper SerializedPropertyList<T>()
        {
            var wrapper = new PropertyWrapper
            {
                RequestType = typeof(T).Name
            };

            var props = typeof(T)
                .GetProperties()
                .ToList();

            var propList = new List<Property>();

            foreach (var prop in props)
                propList.Add(new Property { Name = prop.Name, Value = prop.PropertyType.Name });

            wrapper.Properties = propList.ToArray();

            return wrapper;
        }
    }
}
