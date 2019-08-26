namespace Sentinel.Extractors
{
    using Sentinel.Extractors.Interfaces;
    using Sentinel.Interfaces;
    using System.Runtime.Serialization;

    [DataContract]
    public class SearchExtractor
        : Extractor, IDefaultInitialisation, ISearchExtractor
    {
        public void Initialise()
        {
            Name = "SearchExtractor";
            Field = LogEntryField.System;
            Pattern = string.Empty;
        }
    }
}