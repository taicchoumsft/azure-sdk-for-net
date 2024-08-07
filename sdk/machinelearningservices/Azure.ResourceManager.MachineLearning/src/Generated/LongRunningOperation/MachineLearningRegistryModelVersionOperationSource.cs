// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning
{
    internal class MachineLearningRegistryModelVersionOperationSource : IOperationSource<MachineLearningRegistryModelVersionResource>
    {
        private readonly ArmClient _client;

        internal MachineLearningRegistryModelVersionOperationSource(ArmClient client)
        {
            _client = client;
        }

        MachineLearningRegistryModelVersionResource IOperationSource<MachineLearningRegistryModelVersionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MachineLearningModelVersionData.DeserializeMachineLearningModelVersionData(document.RootElement);
            return new MachineLearningRegistryModelVersionResource(_client, data);
        }

        async ValueTask<MachineLearningRegistryModelVersionResource> IOperationSource<MachineLearningRegistryModelVersionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MachineLearningModelVersionData.DeserializeMachineLearningModelVersionData(document.RootElement);
            return new MachineLearningRegistryModelVersionResource(_client, data);
        }
    }
}
