namespace Sentinel.Extractors.Interfaces
{
    using Sentinel.Interfaces;
    using System.Collections.ObjectModel;
    using System.Runtime.Serialization;

    public interface IExtractingService<T>
    {
        [DataMember]
        ObservableCollection<T> Extractors { get; set; }

        [IgnoreDataMember]
        ObservableCollection<T> SearchExtractors { get; set; }

        bool IsFiltered(ILogEntry entry);
    }
}