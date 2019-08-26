namespace Sentinel.Log4Net
{
    using Sentinel.Interfaces.Providers;
    using System;

    public class ProviderRegistrationInformation : IProviderRegistrationRecord
    {
        public ProviderRegistrationInformation(IProviderInfo providerInfo)
        {
            Info = providerInfo;
        }

        public Guid Identifier => Info.Identifier;

        public IProviderInfo Info { get; private set; }

        public Type Settings => typeof(ConfigurationPage);

        public Type Implementer => typeof(Log4NetProvider);
    }
}