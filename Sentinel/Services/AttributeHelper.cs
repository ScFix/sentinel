namespace Sentinel.Services
{
    using Sentinel.Interfaces.CodeContracts;
    using System;
    using System.Linq;

    public static class AttributeHelper
    {
        public static bool HasAttribute<T>(this Type type)
        {
            type.ThrowIfNull(nameof(type));

            var attributes = type.GetCustomAttributes(typeof(T), true);

            return attributes.Any();
        }

        public static bool HasAttribute<T>(this object obj)
        {
            obj.ThrowIfNull(nameof(obj));

            return obj.GetType().HasAttribute<T>();
        }
    }
}