namespace Sentinel.Views.Interfaces
{
    using Sentinel.Interfaces;
    using System.Collections.Generic;

    public interface IWindowFrame
    {
        ILogger Log { get; set; }

        ILogViewer PrimaryView { get; set; }

        void SetViews(IEnumerable<string> viewIdentifiers);
    }
}