namespace Sentinel.Highlighters
{
    using Common.Logging;
    using Interfaces;
    using Sentinel.Interfaces;
    using System;
    using System.Globalization;
    using System.Windows.Data;

    public class HighlighterConverter : IValueConverter
    {
        private static readonly ILog Log = LogManager.GetLogger<HighlighterConverter>();

        public HighlighterConverter(IHighlighter highlighter)
        {
            Highlighter = highlighter;
        }

        private IHighlighter Highlighter { get; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var match = false;
            if (value != null)
            {
                var entry = value as ILogEntry;
                if (entry == null)
                {
                    Log.WarnFormat("Expected 'value' to be an ILogEntry but found {0}", value);
                }
                else
                {
                    match = Highlighter.Enabled && Highlighter.IsMatch(entry);
                }
            }

            return match ? "Match" : "Not Match";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}