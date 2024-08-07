// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Communication.ShortCodes.Models
{
    /// <summary> A wrapper for a list of short code entities. </summary>
    internal partial class ShortCodes
    {
        /// <summary> Initializes a new instance of <see cref="ShortCodes"/>. </summary>
        internal ShortCodes()
        {
            ShortCodesProperty = new ChangeTrackingList<ShortCode>();
        }

        /// <summary> Initializes a new instance of <see cref="ShortCodes"/>. </summary>
        /// <param name="shortCodesProperty"> List of short codes. </param>
        /// <param name="nextLink"> Represents the URL link to the next page. </param>
        internal ShortCodes(IReadOnlyList<ShortCode> shortCodesProperty, string nextLink)
        {
            ShortCodesProperty = shortCodesProperty;
            NextLink = nextLink;
        }

        /// <summary> List of short codes. </summary>
        public IReadOnlyList<ShortCode> ShortCodesProperty { get; }
        /// <summary> Represents the URL link to the next page. </summary>
        public string NextLink { get; }
    }
}
