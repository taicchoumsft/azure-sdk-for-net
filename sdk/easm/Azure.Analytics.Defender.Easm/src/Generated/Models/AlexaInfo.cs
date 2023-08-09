// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Defender.Easm.Models
{
    /// <summary> The AlexaInfo. </summary>
    public partial class AlexaInfo
    {
        /// <summary> Initializes a new instance of AlexaInfo. </summary>
        internal AlexaInfo()
        {
        }

        /// <summary> Initializes a new instance of AlexaInfo. </summary>
        /// <param name="alexaRank"></param>
        /// <param name="category"></param>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="count"></param>
        /// <param name="recent"></param>
        internal AlexaInfo(long? alexaRank, string category, DateTimeOffset? firstSeen, DateTimeOffset? lastSeen, long? count, bool? recent)
        {
            AlexaRank = alexaRank;
            Category = category;
            FirstSeen = firstSeen;
            LastSeen = lastSeen;
            Count = count;
            Recent = recent;
        }

        /// <summary> Gets the alexa rank. </summary>
        public long? AlexaRank { get; }
        /// <summary> Gets the category. </summary>
        public string Category { get; }
        /// <summary> Gets the first seen. </summary>
        public DateTimeOffset? FirstSeen { get; }
        /// <summary> Gets the last seen. </summary>
        public DateTimeOffset? LastSeen { get; }
        /// <summary> Gets the count. </summary>
        public long? Count { get; }
        /// <summary> Gets the recent. </summary>
        public bool? Recent { get; }
    }
}
