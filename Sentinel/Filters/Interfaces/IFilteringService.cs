namespace Sentinel.Filters.Interfaces
{
    using Sentinel.Interfaces;
    using System.Collections.ObjectModel;
    using System.Runtime.Serialization;

    public interface IFilteringService<T>
    {
        [DataMember]
        ObservableCollection<T> Filters { get; set; }

        ObservableCollection<T> SearchFilters { get; set; }

        bool IsFiltered(ILogEntry entry);
    }
}