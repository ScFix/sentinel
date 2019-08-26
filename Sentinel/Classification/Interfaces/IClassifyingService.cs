namespace Sentinel.Classification.Interfaces
{
    using Sentinel.Interfaces;
    using System.Collections.ObjectModel;
    using System.Runtime.Serialization;
    using System.Windows.Input;

    public interface IClassifyingService<T>
    {
        ICommand Add { get; }

        ICommand Edit { get; }

        [DataMember]
        ObservableCollection<T> Classifiers { get; }

        ICommand OrderEarlier { get; }

        ICommand OrderLater { get; }

        ICommand Remove { get; }

        int SelectedIndex { get; set; }

        ILogEntry Classify(ILogEntry entry);
    }
}