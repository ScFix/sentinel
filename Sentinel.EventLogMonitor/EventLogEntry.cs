﻿namespace Sentinel.EventLogMonitor
{
    using Interfaces;
    using Sentinel.Interfaces.CodeContracts;
    using System;
    using System.Diagnostics;
    using System.Text;

    internal class EventLogEntry : IEventLogEntry
    {
        private System.Diagnostics.EventLogEntry Entry { get; }

        public EventLogEntry(System.Diagnostics.EventLogEntry entry)
        {
            entry.ThrowIfNull(nameof(entry));
            Entry = entry;
        }

        public string MachineName => Entry.MachineName;

        public EventLogEntryType EntryType => Entry.EntryType;

        public string Message => Entry.Message;

        public DateTime EventTime => Entry.TimeGenerated;

        public string Category => Entry.Category;

        public long InstanceId => Entry.InstanceId;

        public string Source => Entry.Source;

        public string UserName => Entry.UserName;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Type    : {EntryType}");
            sb.AppendLine($"Created : {EventTime}");
            sb.AppendLine($"Category: {Category}");
            sb.AppendLine($"Message : {Message}");
            sb.AppendLine($"Machine : {MachineName}");
            sb.AppendLine($"Source  : {Source}");
            sb.AppendLine($"User    : {UserName}");
            sb.AppendLine($"Inst Id : {InstanceId}");

            return sb.ToString();
        }
    }
}