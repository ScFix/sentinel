namespace Sentinel.NLog
{
    using Sentinel.Interfaces.Providers;
    using System;

    internal class ProviderInfo : IProviderInfo
    {
        public Guid Identifier => new Guid("F12581A5-64C0-4B35-91FC-81C9A09C1E0B");

        public string Name => "NLog Viewer Provider";

        public string Description => "Handler for nLog's log4j networking protocol log target.";
    }
}