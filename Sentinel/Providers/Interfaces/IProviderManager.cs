namespace Sentinel.Providers.Interfaces
{
    using Sentinel.Interfaces.Providers;
    using System;
    using System.Collections.Generic;

    public interface IProviderManager : IEnumerable<Guid>
    {
        IEnumerable<ILogProvider> Instances { get; }

        IEnumerable<Guid> Registered { get; }

        void Register(IProviderRegistrationRecord record);

        ILogProvider Create(Guid providerGuid, IProviderSettings settings);

        ILogProvider Get(string name);

        void Remove(string name);

        IProviderInfo GetInformation(Guid providerGuid);

        T GetConfiguration<T>(Guid providerGuid);
    }
}