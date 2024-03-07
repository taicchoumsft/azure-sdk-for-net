// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.MixedReality.Common;

namespace Azure.MixedReality.ObjectAnchors.Conversion.Models
{
    /// <summary> Represents an error response. </summary>
    internal partial class ErrorResponse
    {
        /// <summary> Initializes a new instance of <see cref="ErrorResponse"/>. </summary>
        /// <param name="error"> The Error object. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="error"/> is null. </exception>
        internal ErrorResponse(ErrorDetail error)
        {
            Argument.AssertNotNull(error, nameof(error));

            Error = error;
        }

        /// <summary> The Error object. </summary>
        public ErrorDetail Error { get; }
    }
}
