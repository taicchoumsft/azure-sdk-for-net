// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.AppService
{
    internal class AppServiceCertificateOrderOperationSource : IOperationSource<AppServiceCertificateOrderResource>
    {
        private readonly ArmClient _client;

        internal AppServiceCertificateOrderOperationSource(ArmClient client)
        {
            _client = client;
        }

        AppServiceCertificateOrderResource IOperationSource<AppServiceCertificateOrderResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AppServiceCertificateOrderData.DeserializeAppServiceCertificateOrderData(document.RootElement);
            return new AppServiceCertificateOrderResource(_client, data);
        }

        async ValueTask<AppServiceCertificateOrderResource> IOperationSource<AppServiceCertificateOrderResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AppServiceCertificateOrderData.DeserializeAppServiceCertificateOrderData(document.RootElement);
            return new AppServiceCertificateOrderResource(_client, data);
        }
    }
}
