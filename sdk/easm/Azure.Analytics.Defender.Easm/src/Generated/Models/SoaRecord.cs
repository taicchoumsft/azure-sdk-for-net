// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Defender.Easm.Models
{
    /// <summary> The SoaRecord. </summary>
    public partial class SoaRecord
    {
        /// <summary> Initializes a new instance of SoaRecord. </summary>
        internal SoaRecord()
        {
        }

        /// <summary> Initializes a new instance of SoaRecord. </summary>
        /// <param name="nameServer"></param>
        /// <param name="email"></param>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="count"></param>
        /// <param name="serialNumber"></param>
        /// <param name="recent"></param>
        internal SoaRecord(string nameServer, string email, DateTimeOffset? firstSeen, DateTimeOffset? lastSeen, long? count, long? serialNumber, bool? recent)
        {
            NameServer = nameServer;
            Email = email;
            FirstSeen = firstSeen;
            LastSeen = lastSeen;
            Count = count;
            SerialNumber = serialNumber;
            Recent = recent;
        }

        /// <summary> Gets the name server. </summary>
        public string NameServer { get; }
        /// <summary> Gets the email. </summary>
        public string Email { get; }
        /// <summary> Gets the first seen. </summary>
        public DateTimeOffset? FirstSeen { get; }
        /// <summary> Gets the last seen. </summary>
        public DateTimeOffset? LastSeen { get; }
        /// <summary> Gets the count. </summary>
        public long? Count { get; }
        /// <summary> Gets the serial number. </summary>
        public long? SerialNumber { get; }
        /// <summary> Gets the recent. </summary>
        public bool? Recent { get; }
    }
}
