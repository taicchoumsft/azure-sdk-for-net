// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.StreamAnalytics.Models;

namespace Azure.ResourceManager.StreamAnalytics
{
    /// <summary>
    /// A Class representing a StreamingJobInput along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="StreamingJobInputResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetStreamingJobInputResource method.
    /// Otherwise you can get one from its parent resource <see cref="StreamingJobResource"/> using the GetStreamingJobInput method.
    /// </summary>
    public partial class StreamingJobInputResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StreamingJobInputResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="jobName"> The jobName. </param>
        /// <param name="inputName"> The inputName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string jobName, string inputName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/inputs/{inputName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _streamingJobInputInputsClientDiagnostics;
        private readonly InputsRestOperations _streamingJobInputInputsRestClient;
        private readonly StreamingJobInputData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.StreamAnalytics/streamingjobs/inputs";

        /// <summary> Initializes a new instance of the <see cref="StreamingJobInputResource"/> class for mocking. </summary>
        protected StreamingJobInputResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StreamingJobInputResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StreamingJobInputResource(ArmClient client, StreamingJobInputData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="StreamingJobInputResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StreamingJobInputResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _streamingJobInputInputsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StreamAnalytics", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string streamingJobInputInputsApiVersion);
            _streamingJobInputInputsRestClient = new InputsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, streamingJobInputInputsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual StreamingJobInputData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets details about the specified input.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/inputs/{inputName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inputs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobInputResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StreamingJobInputResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _streamingJobInputInputsClientDiagnostics.CreateScope("StreamingJobInputResource.Get");
            scope.Start();
            try
            {
                var response = await _streamingJobInputInputsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamingJobInputResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details about the specified input.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/inputs/{inputName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inputs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobInputResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StreamingJobInputResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _streamingJobInputInputsClientDiagnostics.CreateScope("StreamingJobInputResource.Get");
            scope.Start();
            try
            {
                var response = _streamingJobInputInputsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamingJobInputResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an input from the streaming job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/inputs/{inputName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inputs_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobInputResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _streamingJobInputInputsClientDiagnostics.CreateScope("StreamingJobInputResource.Delete");
            scope.Start();
            try
            {
                var response = await _streamingJobInputInputsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var uri = _streamingJobInputInputsRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new StreamAnalyticsArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an input from the streaming job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/inputs/{inputName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inputs_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobInputResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _streamingJobInputInputsClientDiagnostics.CreateScope("StreamingJobInputResource.Delete");
            scope.Start();
            try
            {
                var response = _streamingJobInputInputsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var uri = _streamingJobInputInputsRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new StreamAnalyticsArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates an existing input under an existing streaming job. This can be used to partially update (ie. update one or two properties) an input without affecting the rest the job or input definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/inputs/{inputName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inputs_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobInputResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="input"> An Input object. The properties specified here will overwrite the corresponding properties in the existing input (ie. Those properties will be updated). Any properties that are set to null here will mean that the corresponding property in the existing input will remain the same and not change as a result of this PATCH operation. </param>
        /// <param name="ifMatch"> The ETag of the input. Omit this value to always overwrite the current input. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public virtual async Task<Response<StreamingJobInputResource>> UpdateAsync(StreamingJobInputData input, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(input, nameof(input));

            using var scope = _streamingJobInputInputsClientDiagnostics.CreateScope("StreamingJobInputResource.Update");
            scope.Start();
            try
            {
                var response = await _streamingJobInputInputsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, input, ifMatch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new StreamingJobInputResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates an existing input under an existing streaming job. This can be used to partially update (ie. update one or two properties) an input without affecting the rest the job or input definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/inputs/{inputName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inputs_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobInputResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="input"> An Input object. The properties specified here will overwrite the corresponding properties in the existing input (ie. Those properties will be updated). Any properties that are set to null here will mean that the corresponding property in the existing input will remain the same and not change as a result of this PATCH operation. </param>
        /// <param name="ifMatch"> The ETag of the input. Omit this value to always overwrite the current input. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public virtual Response<StreamingJobInputResource> Update(StreamingJobInputData input, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(input, nameof(input));

            using var scope = _streamingJobInputInputsClientDiagnostics.CreateScope("StreamingJobInputResource.Update");
            scope.Start();
            try
            {
                var response = _streamingJobInputInputsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, input, ifMatch, cancellationToken);
                return Response.FromValue(new StreamingJobInputResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tests whether an input’s datasource is reachable and usable by the Azure Stream Analytics service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/inputs/{inputName}/test</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inputs_Test</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobInputResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="input"> If the input specified does not already exist, this parameter must contain the full input definition intended to be tested. If the input specified already exists, this parameter can be left null to test the existing input as is or if specified, the properties specified will overwrite the corresponding properties in the existing input (exactly like a PATCH operation) and the resulting input will be tested. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<StreamAnalyticsResourceTestStatus>> TestAsync(WaitUntil waitUntil, StreamingJobInputData input = null, CancellationToken cancellationToken = default)
        {
            using var scope = _streamingJobInputInputsClientDiagnostics.CreateScope("StreamingJobInputResource.Test");
            scope.Start();
            try
            {
                var response = await _streamingJobInputInputsRestClient.TestAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, input, cancellationToken).ConfigureAwait(false);
                var operation = new StreamAnalyticsArmOperation<StreamAnalyticsResourceTestStatus>(new StreamAnalyticsResourceTestStatusOperationSource(), _streamingJobInputInputsClientDiagnostics, Pipeline, _streamingJobInputInputsRestClient.CreateTestRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, input).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tests whether an input’s datasource is reachable and usable by the Azure Stream Analytics service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/inputs/{inputName}/test</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inputs_Test</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobInputResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="input"> If the input specified does not already exist, this parameter must contain the full input definition intended to be tested. If the input specified already exists, this parameter can be left null to test the existing input as is or if specified, the properties specified will overwrite the corresponding properties in the existing input (exactly like a PATCH operation) and the resulting input will be tested. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<StreamAnalyticsResourceTestStatus> Test(WaitUntil waitUntil, StreamingJobInputData input = null, CancellationToken cancellationToken = default)
        {
            using var scope = _streamingJobInputInputsClientDiagnostics.CreateScope("StreamingJobInputResource.Test");
            scope.Start();
            try
            {
                var response = _streamingJobInputInputsRestClient.Test(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, input, cancellationToken);
                var operation = new StreamAnalyticsArmOperation<StreamAnalyticsResourceTestStatus>(new StreamAnalyticsResourceTestStatusOperationSource(), _streamingJobInputInputsClientDiagnostics, Pipeline, _streamingJobInputInputsRestClient.CreateTestRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, input).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
