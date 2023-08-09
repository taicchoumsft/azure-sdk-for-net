// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Defender.Easm.Models
{
    /// <summary> The Cve. </summary>
#pragma warning disable AZC0012 // Avoid single word type names
    public partial class Cve
#pragma warning restore AZC0012 // Avoid single word type names
    {
        /// <summary> Initializes a new instance of Cve. </summary>
        internal Cve()
        {
        }

        /// <summary> Initializes a new instance of Cve. </summary>
        /// <param name="name"></param>
        /// <param name="cweId"></param>
        /// <param name="cvssScore"></param>
        /// <param name="cvss3Summary"></param>
        internal Cve(string name, string cweId, float? cvssScore, CVSS3Summary cvss3Summary)
        {
            Name = name;
            CweId = cweId;
            CvssScore = cvssScore;
            Cvss3Summary = cvss3Summary;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the cwe id. </summary>
        public string CweId { get; }
        /// <summary> Gets the cvss score. </summary>
        public float? CvssScore { get; }
        /// <summary> Gets the cvss 3 summary. </summary>
        public CVSS3Summary Cvss3Summary { get; }
    }
}
