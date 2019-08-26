namespace Sentinel.Providers
{
    using Sentinel.Interfaces.Providers;
    using System;

    public class ProviderInfo : IProviderInfo
    {
        public ProviderInfo(Guid uniqueId, string name, string description)
        {
            Identifier = uniqueId;
            Name = name;
            Description = description;
        }

        public Guid Identifier { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }
    }
}