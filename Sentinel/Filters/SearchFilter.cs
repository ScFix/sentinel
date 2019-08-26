namespace Sentinel.Filters
{
    using Sentinel.Filters.Interfaces;
    using Sentinel.Interfaces;
    using System.Runtime.Serialization;

    [DataContract]
    public class SearchFilter : Filter, IDefaultInitialisation, ISearchFilter
    {
        public void Initialise()
        {
            Name = "SearchFilter";
            Field = LogEntryField.System;
            Pattern = string.Empty;
        }
    }
}