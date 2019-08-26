namespace Sentinel.Logs.Interfaces
{
    using Sentinel.Interfaces;
    using System.Collections.Generic;

    public interface ILogManager : IEnumerable<ILogger>
    {
        ILogger Add(string logName);

        ILogger Get(string name);

        void Remove(string name);
    }
}