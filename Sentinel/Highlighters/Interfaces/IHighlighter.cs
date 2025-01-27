namespace Sentinel.Highlighters.Interfaces
{
    using Sentinel.Interfaces;
    using System.Runtime.Serialization;

    public interface IHighlighter
    {
        [DataMember]
        string Name { get; set; }

        [DataMember]
        bool Enabled { get; set; }

        [DataMember]
        LogEntryField Field { get; set; }

        [DataMember]
        MatchMode Mode { get; set; }

        [DataMember]
        string Pattern { get; set; }

        [DataMember]
        string Description { get; }

        [DataMember]
        IHighlighterStyle Style { get; set; }

        bool IsMatch(ILogEntry logEntry);
    }
}