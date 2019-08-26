namespace Sentinel.Providers
{
    using Sentinel.Interfaces.Providers;
    using System;

    public class ProviderRegistrationRecord : IProviderRegistrationRecord
    {
        public Guid Identifier { get; set; }

        public IProviderInfo Info { get; set; }

        public Type Settings { get; set; }

        public Type Implementer { get; set; }
    }
}