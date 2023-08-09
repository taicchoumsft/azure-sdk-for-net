// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm.Models
{
    /// <summary> The DiscoRunPageResponse. </summary>
    public partial class DiscoRunPageResponse
    {
        /// <summary> Initializes a new instance of DiscoRunPageResponse. </summary>
        internal DiscoRunPageResponse()
        {
            Value = new ChangeTrackingList<DiscoRunResponse>();
        }

        /// <summary> Initializes a new instance of DiscoRunPageResponse. </summary>
        /// <param name="totalElements"> The total number of items available in the full result set. </param>
        /// <param name="nextLink"> The link to access the next page of results.  Not set if at the end of the result set. </param>
        /// <param name="value"> The items in the current page of results. </param>
        internal DiscoRunPageResponse(long? totalElements, string nextLink, IReadOnlyList<DiscoRunResponse> value)
        {
            TotalElements = totalElements;
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The total number of items available in the full result set. </summary>
        public long? TotalElements { get; }
        /// <summary> The link to access the next page of results.  Not set if at the end of the result set. </summary>
        public string NextLink { get; }
        /// <summary> The items in the current page of results. </summary>
        public IReadOnlyList<DiscoRunResponse> Value { get; }
    }
}
