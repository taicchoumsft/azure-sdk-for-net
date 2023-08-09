// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Defender.Easm.Models
{
    /// <summary> The HostCore. </summary>
    public partial class HostCore
    {
        /// <summary> Initializes a new instance of HostCore. </summary>
        internal HostCore()
        {
        }

        /// <summary> Initializes a new instance of HostCore. </summary>
        /// <param name="host"></param>
        /// <param name="domain"></param>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="count"></param>
        /// <param name="blacklistCauseFirstSeen"></param>
        /// <param name="blacklistCauseLastSeen"></param>
        /// <param name="blacklistCauseCount"></param>
        /// <param name="blacklistResourceFirstSeen"></param>
        /// <param name="blacklistResourceLastSeen"></param>
        /// <param name="blacklistResourceCount"></param>
        /// <param name="blacklistSequenceFirstSeen"></param>
        /// <param name="blacklistSequenceLastSeen"></param>
        /// <param name="blacklistSequenceCount"></param>
        /// <param name="phishCauseCount"></param>
        /// <param name="malwareCauseCount"></param>
        /// <param name="spamCauseCount"></param>
        /// <param name="scamCauseCount"></param>
        /// <param name="phishResourceCount"></param>
        /// <param name="malwareResourceCount"></param>
        /// <param name="spamResourceCount"></param>
        /// <param name="scamResourceCount"></param>
        /// <param name="phishSequenceCount"></param>
        /// <param name="malwareSequenceCount"></param>
        /// <param name="spamSequenceCount"></param>
        /// <param name="scamSequenceCount"></param>
        /// <param name="alexaRank"></param>
        /// <param name="hostReputationScore"></param>
        /// <param name="hostPhishReputationScore"></param>
        /// <param name="hostMalwareReputationScore"></param>
        /// <param name="hostSpamReputationScore"></param>
        /// <param name="hostScamReputationScore"></param>
        /// <param name="domainReputationScore"></param>
        /// <param name="domainPhishReputationScore"></param>
        /// <param name="domainMalwareReputationScore"></param>
        /// <param name="domainSpamReputationScore"></param>
        /// <param name="domainScamReputationScore"></param>
        /// <param name="uuid"></param>
        internal HostCore(string host, string domain, DateTimeOffset? firstSeen, DateTimeOffset? lastSeen, long? count, DateTimeOffset? blacklistCauseFirstSeen, DateTimeOffset? blacklistCauseLastSeen, long? blacklistCauseCount, DateTimeOffset? blacklistResourceFirstSeen, DateTimeOffset? blacklistResourceLastSeen, long? blacklistResourceCount, DateTimeOffset? blacklistSequenceFirstSeen, DateTimeOffset? blacklistSequenceLastSeen, long? blacklistSequenceCount, long? phishCauseCount, long? malwareCauseCount, long? spamCauseCount, long? scamCauseCount, long? phishResourceCount, long? malwareResourceCount, long? spamResourceCount, long? scamResourceCount, long? phishSequenceCount, long? malwareSequenceCount, long? spamSequenceCount, long? scamSequenceCount, int? alexaRank, int? hostReputationScore, int? hostPhishReputationScore, int? hostMalwareReputationScore, int? hostSpamReputationScore, int? hostScamReputationScore, int? domainReputationScore, int? domainPhishReputationScore, int? domainMalwareReputationScore, int? domainSpamReputationScore, int? domainScamReputationScore, string uuid)
        {
            Host = host;
            Domain = domain;
            FirstSeen = firstSeen;
            LastSeen = lastSeen;
            Count = count;
            BlacklistCauseFirstSeen = blacklistCauseFirstSeen;
            BlacklistCauseLastSeen = blacklistCauseLastSeen;
            BlacklistCauseCount = blacklistCauseCount;
            BlacklistResourceFirstSeen = blacklistResourceFirstSeen;
            BlacklistResourceLastSeen = blacklistResourceLastSeen;
            BlacklistResourceCount = blacklistResourceCount;
            BlacklistSequenceFirstSeen = blacklistSequenceFirstSeen;
            BlacklistSequenceLastSeen = blacklistSequenceLastSeen;
            BlacklistSequenceCount = blacklistSequenceCount;
            PhishCauseCount = phishCauseCount;
            MalwareCauseCount = malwareCauseCount;
            SpamCauseCount = spamCauseCount;
            ScamCauseCount = scamCauseCount;
            PhishResourceCount = phishResourceCount;
            MalwareResourceCount = malwareResourceCount;
            SpamResourceCount = spamResourceCount;
            ScamResourceCount = scamResourceCount;
            PhishSequenceCount = phishSequenceCount;
            MalwareSequenceCount = malwareSequenceCount;
            SpamSequenceCount = spamSequenceCount;
            ScamSequenceCount = scamSequenceCount;
            AlexaRank = alexaRank;
            HostReputationScore = hostReputationScore;
            HostPhishReputationScore = hostPhishReputationScore;
            HostMalwareReputationScore = hostMalwareReputationScore;
            HostSpamReputationScore = hostSpamReputationScore;
            HostScamReputationScore = hostScamReputationScore;
            DomainReputationScore = domainReputationScore;
            DomainPhishReputationScore = domainPhishReputationScore;
            DomainMalwareReputationScore = domainMalwareReputationScore;
            DomainSpamReputationScore = domainSpamReputationScore;
            DomainScamReputationScore = domainScamReputationScore;
            Uuid = uuid;
        }

        /// <summary> Gets the host. </summary>
        public string Host { get; }
        /// <summary> Gets the domain. </summary>
        public string Domain { get; }
        /// <summary> Gets the first seen. </summary>
        public DateTimeOffset? FirstSeen { get; }
        /// <summary> Gets the last seen. </summary>
        public DateTimeOffset? LastSeen { get; }
        /// <summary> Gets the count. </summary>
        public long? Count { get; }
        /// <summary> Gets the blacklist cause first seen. </summary>
        public DateTimeOffset? BlacklistCauseFirstSeen { get; }
        /// <summary> Gets the blacklist cause last seen. </summary>
        public DateTimeOffset? BlacklistCauseLastSeen { get; }
        /// <summary> Gets the blacklist cause count. </summary>
        public long? BlacklistCauseCount { get; }
        /// <summary> Gets the blacklist resource first seen. </summary>
        public DateTimeOffset? BlacklistResourceFirstSeen { get; }
        /// <summary> Gets the blacklist resource last seen. </summary>
        public DateTimeOffset? BlacklistResourceLastSeen { get; }
        /// <summary> Gets the blacklist resource count. </summary>
        public long? BlacklistResourceCount { get; }
        /// <summary> Gets the blacklist sequence first seen. </summary>
        public DateTimeOffset? BlacklistSequenceFirstSeen { get; }
        /// <summary> Gets the blacklist sequence last seen. </summary>
        public DateTimeOffset? BlacklistSequenceLastSeen { get; }
        /// <summary> Gets the blacklist sequence count. </summary>
        public long? BlacklistSequenceCount { get; }
        /// <summary> Gets the phish cause count. </summary>
        public long? PhishCauseCount { get; }
        /// <summary> Gets the malware cause count. </summary>
        public long? MalwareCauseCount { get; }
        /// <summary> Gets the spam cause count. </summary>
        public long? SpamCauseCount { get; }
        /// <summary> Gets the scam cause count. </summary>
        public long? ScamCauseCount { get; }
        /// <summary> Gets the phish resource count. </summary>
        public long? PhishResourceCount { get; }
        /// <summary> Gets the malware resource count. </summary>
        public long? MalwareResourceCount { get; }
        /// <summary> Gets the spam resource count. </summary>
        public long? SpamResourceCount { get; }
        /// <summary> Gets the scam resource count. </summary>
        public long? ScamResourceCount { get; }
        /// <summary> Gets the phish sequence count. </summary>
        public long? PhishSequenceCount { get; }
        /// <summary> Gets the malware sequence count. </summary>
        public long? MalwareSequenceCount { get; }
        /// <summary> Gets the spam sequence count. </summary>
        public long? SpamSequenceCount { get; }
        /// <summary> Gets the scam sequence count. </summary>
        public long? ScamSequenceCount { get; }
        /// <summary> Gets the alexa rank. </summary>
        public int? AlexaRank { get; }
        /// <summary> Gets the host reputation score. </summary>
        public int? HostReputationScore { get; }
        /// <summary> Gets the host phish reputation score. </summary>
        public int? HostPhishReputationScore { get; }
        /// <summary> Gets the host malware reputation score. </summary>
        public int? HostMalwareReputationScore { get; }
        /// <summary> Gets the host spam reputation score. </summary>
        public int? HostSpamReputationScore { get; }
        /// <summary> Gets the host scam reputation score. </summary>
        public int? HostScamReputationScore { get; }
        /// <summary> Gets the domain reputation score. </summary>
        public int? DomainReputationScore { get; }
        /// <summary> Gets the domain phish reputation score. </summary>
        public int? DomainPhishReputationScore { get; }
        /// <summary> Gets the domain malware reputation score. </summary>
        public int? DomainMalwareReputationScore { get; }
        /// <summary> Gets the domain spam reputation score. </summary>
        public int? DomainSpamReputationScore { get; }
        /// <summary> Gets the domain scam reputation score. </summary>
        public int? DomainScamReputationScore { get; }
        /// <summary> Gets the uuid. </summary>
        public string Uuid { get; }
    }
}
