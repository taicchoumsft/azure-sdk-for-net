// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    internal class ExportSummaryOperationSource : IOperationSource<ExportSummary>
    {
        ExportSummary IOperationSource<ExportSummary>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ExportSummary.DeserializeExportSummary(document.RootElement);
        }

        async ValueTask<ExportSummary> IOperationSource<ExportSummary>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ExportSummary.DeserializeExportSummary(document.RootElement);
        }
    }
}
