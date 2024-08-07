// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Unknown version of FormatWriteSettings. </summary>
    internal partial class UnknownFormatWriteSettings : FormatWriteSettings
    {
        /// <summary> Initializes a new instance of <see cref="UnknownFormatWriteSettings"/>. </summary>
        /// <param name="type"> The write setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownFormatWriteSettings(string type, IDictionary<string, object> additionalProperties) : base(type, additionalProperties)
        {
            Type = type ?? "Unknown";
        }
    }
}
