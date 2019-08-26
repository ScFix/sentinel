namespace Sentinel.Providers.Interfaces
{
    using Sentinel.Interfaces.Providers;
    using System.Windows;

    public interface INewProviderWizard
    {
        IProviderInfo Provider { get; }

        IProviderSettings Settings { get; }

        bool Display(Window parent);
    }
}