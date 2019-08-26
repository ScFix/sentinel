namespace Sentinel.Highlighters.Interfaces
{
    using Sentinel.Interfaces;
    using System.Collections.ObjectModel;
    using System.Windows.Input;

    public interface IHighlightingService<T>
        where T : IHighlighter
    {
        ICommand Add { get; }

        ICommand Edit { get; }

        ObservableCollection<T> Highlighters { get; set; }

        ICommand OrderEarlier { get; }

        ICommand OrderLater { get; }

        ICommand Remove { get; }

        int SelectedIndex { get; set; }

        IHighlighterStyle IsHighlighted(ILogEntry entry);
    }
}