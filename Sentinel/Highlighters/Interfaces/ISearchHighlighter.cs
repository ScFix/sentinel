namespace Sentinel.Highlighters.Interfaces
{
    using Sentinel.Interfaces;
    using System.Collections.Generic;

    public interface ISearchHighlighter
    {
        IEnumerable<LogEntryField> Fields { get; }

        LogEntryField Field { get; set; }

        bool Enabled { get; set; }

        MatchMode Mode { get; set; }

        IHighlighter Highlighter { get; }

        string Search { get; set; }
    }
}