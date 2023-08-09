// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Defender.Easm.Models
{
    /// <summary> The ValidateResponse. </summary>
    public partial class ValidateResponse
    {
        /// <summary> Initializes a new instance of ValidateResponse. </summary>
        internal ValidateResponse()
        {
        }

        /// <summary> Initializes a new instance of ValidateResponse. </summary>
        /// <param name="error"> This is the top-level error object whose code matches the x-ms-error-code response header. </param>
        internal ValidateResponse(ErrorDetail error)
        {
            Error = error;
        }

        /// <summary> This is the top-level error object whose code matches the x-ms-error-code response header. </summary>
        public ErrorDetail Error { get; }
    }
}
