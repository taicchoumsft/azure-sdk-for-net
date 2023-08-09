// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Analytics.Defender.Easm;
using Azure.Core.Extensions;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="EasmDefenderClient"/> to client builder. </summary>
    public static partial class AnalyticsDefenderEasmClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="EasmDefenderClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The endpoint hosting the requested resource. For example, https://{region}.easm.defender.microsoft.com. </param>
        public static IAzureClientBuilder<EasmDefenderClient, EasmDefenderClientOptions> AddEasmDefenderClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<EasmDefenderClient, EasmDefenderClientOptions>((options, cred) => new EasmDefenderClient(endpoint, cred, options));
        }

        /// <summary> Registers a <see cref="EasmDefenderClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<EasmDefenderClient, EasmDefenderClientOptions> AddEasmDefenderClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<EasmDefenderClient, EasmDefenderClientOptions>(configuration);
        }
    }
}
