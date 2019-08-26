namespace Sentinel.NLog
{
    using Sentinel.Interfaces.Providers;
    using System.Runtime.Serialization;

    [DataContract]
    public class ProviderSettings : IProviderSettings
    {
        public string Name { get; set; }

        public virtual string Summary => $"Provider named {Name}";

        /// <summary>
        /// Reference back to the provider this setting is appropriate to.
        /// </summary>
        public IProviderInfo Info { get; set; }
    }
}