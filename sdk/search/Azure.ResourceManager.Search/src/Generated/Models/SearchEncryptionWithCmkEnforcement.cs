// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Describes how a search service should enforce compliance if it finds objects that aren't encrypted with the customer-managed key. </summary>
    public enum SearchEncryptionWithCmkEnforcement
    {
        /// <summary> Enforcement policy is not explicitly specified, with the behavior being the same as if it were set to 'Disabled'. </summary>
        Unspecified,
        /// <summary> No enforcement of customer-managed key encryption will be made. Only the built-in service-managed encryption is used. </summary>
        Disabled,
        /// <summary> Search service will be marked as non-compliant if one or more objects aren't encrypted with a customer-managed key. </summary>
        Enabled
    }
}
