#region License

//
// � Copyright Ray Hayes
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.
//

#endregion

namespace Sentinel.Filters
{
    using System.Diagnostics;
    using System.Runtime.Serialization;
    using System.Text.RegularExpressions;

    using Sentinel.Filters.Interfaces;
    using Sentinel.Interfaces;
    using Sentinel.Support.Mvvm;

    [DataContract]
    public class Filter : ViewModelBase, IFilter
    {
        /// <summary>
        /// Is the filter enabled?  If so, it will remove anything matching from the output.
        /// </summary>
        private bool enabled;

        private string name;

        private string pattern;

        private LogEntryField field;

        private MatchMode mode = MatchMode.Exact;

        private Regex regex;

        public Filter()
        {
            PropertyChanged += (sender, e) =>
                {
                    if (e.PropertyName == "Pattern" || e.PropertyName == "Mode")
                    {
                        if (Mode == MatchMode.RegularExpression)
                        {
                            regex = string.IsNullOrWhiteSpace(Pattern) ? null : new Regex(Pattern);
                        }
                    }

                    if (e.PropertyName == "Field" || e.PropertyName == "Mode" || e.PropertyName == "Pattern")
                    {
                        OnPropertyChanged("Description");
                    }
                };
        }

        public Filter(string name, LogEntryField field, string pattern)
        {
            Name = name;
            Pattern = pattern;
            Field = field;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the filter is enabled.
        /// </summary>
        public bool Enabled
        {
            get
            {
                return enabled;
            }

            set
            {
                if (value != enabled)
                {
                    enabled = value;
                    OnPropertyChanged("Enabled");
                }
            }
        }

        public string Pattern
        {
            get
            {
                return pattern;
            }

            set
            {
                if (pattern != value)
                {
                    pattern = value;
                    OnPropertyChanged("Pattern");
                }
            }
        }

        public LogEntryField Field
        {
            get
            {
                return field;
            }

            set
            {
                if (field != value)
                {
                    field = value;
                    OnPropertyChanged("Field");
                }
            }
        }

        public MatchMode Mode
        {
            get
            {
                return mode;
            }

            set
            {
                if (mode != value)
                {
                    mode = value;
                    OnPropertyChanged("Mode");
                }
            }
        }

        public string Description
        {
            get
            {
                string modeDescription = "exact";
                switch (Mode)
                {
                    case MatchMode.RegularExpression:
                        modeDescription = "regex";
                        break;
                    case MatchMode.Substring:
                        modeDescription = "substring";
                        break;
                }

                return string.Format("{0} match of {1} in the {2} field", modeDescription, Pattern, Field);
            }
        }

        public bool IsMatch(ILogEntry entry)
        {
            Debug.Assert(entry != null, "LogEntry can not be null.");

            string target = Field == LogEntryField.System ? entry.System : entry.Type;

            switch (Mode)
            {
                case MatchMode.Exact:
                    return target.Equals(Pattern);
                case MatchMode.Substring:
                    return target.Contains(Pattern);
                case MatchMode.RegularExpression:
                    return regex != null && regex.IsMatch(target);
                default:
                    return false;
            }
        }

#if DEBUG
        public override string ToString()
        {
            return Description;
        }
#endif
    }
}