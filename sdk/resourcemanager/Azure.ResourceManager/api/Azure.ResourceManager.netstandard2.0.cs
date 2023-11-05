namespace Azure.ResourceManager
{
    public partial class ArmClient
    {
        protected ArmClient() { }
        public ArmClient(Azure.Core.TokenCredential credential) { }
        public ArmClient(Azure.Core.TokenCredential credential, string defaultSubscriptionId) { }
        public ArmClient(Azure.Core.TokenCredential credential, string defaultSubscriptionId, Azure.ResourceManager.ArmClientOptions options) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual T GetCachedClient<T>(System.Func<Azure.ResourceManager.ArmClient, T> clientFactory) where T : class { throw null; }
        public virtual Azure.ResourceManager.Resources.DataPolicyManifestResource GetDataPolicyManifestResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Resources.SubscriptionResource GetDefaultSubscription(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.Resources.SubscriptionResource> GetDefaultSubscriptionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Resources.FeatureResource GetFeatureResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Resources.GenericResource GetGenericResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Resources.GenericResourceCollection GetGenericResources() { throw null; }
        public virtual Azure.ResourceManager.Resources.ManagementGroupPolicyDefinitionResource GetManagementGroupPolicyDefinitionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Resources.ManagementGroupPolicySetDefinitionResource GetManagementGroupPolicySetDefinitionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ManagementGroups.ManagementGroupResource GetManagementGroupResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ManagementGroups.ManagementGroupCollection GetManagementGroups() { throw null; }
        public virtual Azure.ResourceManager.Resources.ManagementLockResource GetManagementLockResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Resources.PolicyAssignmentResource GetPolicyAssignmentResource(Azure.Core.ResourceIdentifier id) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual T GetResourceClient<T>(System.Func<T> resourceFactory) where T : Azure.ResourceManager.ArmResource { throw null; }
        public virtual Azure.ResourceManager.Resources.ResourceGroupResource GetResourceGroupResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Resources.ResourceProviderResource GetResourceProviderResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Resources.SubscriptionPolicyDefinitionResource GetSubscriptionPolicyDefinitionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Resources.SubscriptionPolicySetDefinitionResource GetSubscriptionPolicySetDefinitionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Resources.SubscriptionResource GetSubscriptionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Resources.SubscriptionCollection GetSubscriptions() { throw null; }
        public virtual Azure.ResourceManager.Resources.TagResource GetTagResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Resources.TenantPolicyDefinitionResource GetTenantPolicyDefinitionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Resources.TenantPolicySetDefinitionResource GetTenantPolicySetDefinitionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.Models.TenantResourceProvider> GetTenantResourceProvider(string resourceProviderNamespace, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.Models.TenantResourceProvider>> GetTenantResourceProviderAsync(string resourceProviderNamespace, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This method is obsolete as the `top` parameter is not supported by service and will be removed in a future release.", false)]
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.Models.TenantResourceProvider> GetTenantResourceProviders(int? top, string expand, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.Models.TenantResourceProvider> GetTenantResourceProviders(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This method is obsolete as the `top` parameter is not supported by service and will be removed in a future release.", false)]
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.Models.TenantResourceProvider> GetTenantResourceProvidersAsync(int? top, string expand, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.Models.TenantResourceProvider> GetTenantResourceProvidersAsync(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Resources.TenantCollection GetTenants() { throw null; }
    }
    public sealed partial class ArmClientOptions : Azure.Core.ClientOptions
    {
        public ArmClientOptions() { }
        public Azure.ResourceManager.ArmEnvironment? Environment { get { throw null; } set { } }
        public void SetApiVersion(Azure.Core.ResourceType resourceType, string apiVersion) { }
        public void SetApiVersionsFromProfile(Azure.ResourceManager.AzureStackProfile profile) { }
    }
    public abstract partial class ArmCollection
    {
        protected ArmCollection() { }
        protected ArmCollection(Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { }
        protected internal virtual Azure.ResourceManager.ArmClient Client { get { throw null; } }
        protected internal Azure.Core.DiagnosticsOptions Diagnostics { get { throw null; } }
        protected internal System.Uri Endpoint { get { throw null; } }
        public virtual Azure.Core.ResourceIdentifier Id { get { throw null; } }
        protected internal Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual T GetCachedClient<T>(System.Func<Azure.ResourceManager.ArmClient, T> clientFactory) where T : class { throw null; }
        protected bool TryGetApiVersion(Azure.Core.ResourceType resourceType, out string apiVersion) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ArmEnvironment : System.IEquatable<Azure.ResourceManager.ArmEnvironment>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public static readonly Azure.ResourceManager.ArmEnvironment AzureChina;
        public static readonly Azure.ResourceManager.ArmEnvironment AzureGermany;
        public static readonly Azure.ResourceManager.ArmEnvironment AzureGovernment;
        public static readonly Azure.ResourceManager.ArmEnvironment AzurePublicCloud;
        public ArmEnvironment(System.Uri endpoint, string audience) { throw null; }
        public string Audience { get { throw null; } }
        public string DefaultScope { get { throw null; } }
        public System.Uri Endpoint { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ArmEnvironment other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ArmEnvironment left, Azure.ResourceManager.ArmEnvironment right) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ArmEnvironment left, Azure.ResourceManager.ArmEnvironment right) { throw null; }
        public override string ToString() { throw null; }
    }
    public abstract partial class ArmOperation : Azure.Operation
    {
        protected ArmOperation() { }
    }
    public abstract partial class ArmOperation<T> : Azure.Operation<T>
    {
        protected ArmOperation() { }
    }
    public abstract partial class ArmResource
    {
        protected ArmResource() { }
        protected internal ArmResource(Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { }
        protected internal virtual Azure.ResourceManager.ArmClient Client { get { throw null; } }
        protected internal Azure.Core.DiagnosticsOptions Diagnostics { get { throw null; } }
        protected internal System.Uri Endpoint { get { throw null; } }
        public virtual Azure.Core.ResourceIdentifier Id { get { throw null; } }
        protected internal Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        protected virtual bool CanUseTagResource(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        protected virtual System.Threading.Tasks.Task<bool> CanUseTagResourceAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IEnumerable<Azure.Core.AzureLocation>> GetAvailableLocations(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IEnumerable<Azure.Core.AzureLocation>>> GetAvailableLocationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual T GetCachedClient<T>(System.Func<Azure.ResourceManager.ArmClient, T> clientFactory) where T : class { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.ManagementLockResource> GetManagementLock(string lockName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.ManagementLockResource>> GetManagementLockAsync(string lockName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Resources.ManagementLockCollection GetManagementLocks() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.PolicyAssignmentResource> GetPolicyAssignment(string policyAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.PolicyAssignmentResource>> GetPolicyAssignmentAsync(string policyAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Resources.PolicyAssignmentCollection GetPolicyAssignments() { throw null; }
        public virtual Azure.ResourceManager.Resources.TagResource GetTagResource() { throw null; }
        protected virtual bool TryGetApiVersion(Azure.Core.ResourceType resourceType, out string apiVersion) { throw null; }
    }
    public enum AzureStackProfile
    {
        Profile20200901Hybrid = 0,
    }
}
namespace Azure.ResourceManager.ManagementGroups
{
    public partial class ManagementGroupCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ManagementGroups.ManagementGroupResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ManagementGroups.ManagementGroupResource>, System.Collections.IEnumerable
    {
        protected ManagementGroupCollection() { }
        public virtual Azure.Response<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityResult> CheckNameAvailability(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityResult>> CheckNameAvailabilityAsync(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ManagementGroups.ManagementGroupResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string groupId, Azure.ResourceManager.ManagementGroups.Models.ManagementGroupCreateOrUpdateContent content, string cacheControl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ManagementGroups.ManagementGroupResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string groupId, Azure.ResourceManager.ManagementGroups.Models.ManagementGroupCreateOrUpdateContent content, string cacheControl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string groupId, Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType? expand = default(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType?), bool? recurse = default(bool?), string filter = null, string cacheControl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string groupId, Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType? expand = default(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType?), bool? recurse = default(bool?), string filter = null, string cacheControl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ManagementGroups.ManagementGroupResource> Get(string groupId, Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType? expand = default(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType?), bool? recurse = default(bool?), string filter = null, string cacheControl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ManagementGroups.ManagementGroupResource> GetAll(string cacheControl = null, string skiptoken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ManagementGroups.ManagementGroupResource> GetAllAsync(string cacheControl = null, string skiptoken = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ManagementGroups.ManagementGroupResource>> GetAsync(string groupId, Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType? expand = default(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType?), bool? recurse = default(bool?), string filter = null, string cacheControl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ManagementGroups.ManagementGroupResource> GetIfExists(string groupId, Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType? expand = default(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType?), bool? recurse = default(bool?), string filter = null, string cacheControl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ManagementGroups.ManagementGroupResource>> GetIfExistsAsync(string groupId, Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType? expand = default(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType?), bool? recurse = default(bool?), string filter = null, string cacheControl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ManagementGroups.ManagementGroupResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ManagementGroups.ManagementGroupResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ManagementGroups.ManagementGroupResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ManagementGroups.ManagementGroupResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ManagementGroupData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.ManagementGroupData>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.ManagementGroupData>
    {
        internal ManagementGroupData() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildInfo> Children { get { throw null; } }
        public Azure.ResourceManager.ManagementGroups.Models.ManagementGroupInfo Details { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public System.Guid? TenantId { get { throw null; } }
        Azure.ResourceManager.ManagementGroups.ManagementGroupData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.ManagementGroupData>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.ManagementGroupData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.ManagementGroupData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ManagementGroups.ManagementGroupData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.ManagementGroupData>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.ManagementGroupData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagementGroupResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ManagementGroupResource() { }
        public virtual Azure.ResourceManager.ManagementGroups.ManagementGroupData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string groupId) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, string cacheControl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, string cacheControl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ManagementGroups.ManagementGroupResource> Get(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType? expand = default(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType?), bool? recurse = default(bool?), string filter = null, string cacheControl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ManagementGroups.ManagementGroupResource>> GetAsync(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType? expand = default(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType?), bool? recurse = default(bool?), string filter = null, string cacheControl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ManagementGroups.Models.DescendantData> GetDescendants(string skiptoken = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ManagementGroups.Models.DescendantData> GetDescendantsAsync(string skiptoken = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.ManagementGroupPolicyDefinitionResource> GetManagementGroupPolicyDefinition(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.ManagementGroupPolicyDefinitionResource>> GetManagementGroupPolicyDefinitionAsync(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Resources.ManagementGroupPolicyDefinitionCollection GetManagementGroupPolicyDefinitions() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.ManagementGroupPolicySetDefinitionResource> GetManagementGroupPolicySetDefinition(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.ManagementGroupPolicySetDefinitionResource>> GetManagementGroupPolicySetDefinitionAsync(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Resources.ManagementGroupPolicySetDefinitionCollection GetManagementGroupPolicySetDefinitions() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ManagementGroups.ManagementGroupResource> Update(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPatch patch, string cacheControl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ManagementGroups.ManagementGroupResource>> UpdateAsync(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPatch patch, string cacheControl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.ManagementGroups.Models
{
    public partial class CreateManagementGroupDetails : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.CreateManagementGroupDetails>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.CreateManagementGroupDetails>
    {
        public CreateManagementGroupDetails() { }
        public Azure.ResourceManager.ManagementGroups.Models.ManagementGroupParentCreateOptions Parent { get { throw null; } set { } }
        public string UpdatedBy { get { throw null; } }
        public System.DateTimeOffset? UpdatedOn { get { throw null; } }
        public int? Version { get { throw null; } }
        Azure.ResourceManager.ManagementGroups.Models.CreateManagementGroupDetails System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.CreateManagementGroupDetails>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.CreateManagementGroupDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.CreateManagementGroupDetails>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ManagementGroups.Models.CreateManagementGroupDetails System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.CreateManagementGroupDetails>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.CreateManagementGroupDetails>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DescendantData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.DescendantData>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.DescendantData>
    {
        internal DescendantData() { }
        public string DisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier ParentId { get { throw null; } }
        Azure.ResourceManager.ManagementGroups.Models.DescendantData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.DescendantData>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.DescendantData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.DescendantData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ManagementGroups.Models.DescendantData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.DescendantData>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.DescendantData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagementGroupChildInfo : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildInfo>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildInfo>
    {
        internal ManagementGroupChildInfo() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildInfo> Children { get { throw null; } }
        public Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildType? ChildType { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public string Id { get { throw null; } }
        public string Name { get { throw null; } }
        Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildInfo System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildInfo>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildInfo>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildInfo System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildInfo>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildInfo>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagementGroupChildOptions : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildOptions>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildOptions>
    {
        internal ManagementGroupChildOptions() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildOptions> Children { get { throw null; } }
        public Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildType? ChildType { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public string Id { get { throw null; } }
        public string Name { get { throw null; } }
        Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildOptions System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildOptions>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildOptions>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildOptions>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildOptions System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildOptions>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildOptions>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ManagementGroupChildType : System.IEquatable<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ManagementGroupChildType(string value) { throw null; }
        public static Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildType MicrosoftManagementManagementGroups { get { throw null; } }
        public static Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildType Subscriptions { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildType left, Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildType left, Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ManagementGroupCreateOrUpdateContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupCreateOrUpdateContent>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupCreateOrUpdateContent>
    {
        public ManagementGroupCreateOrUpdateContent() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildOptions> Children { get { throw null; } }
        public Azure.ResourceManager.ManagementGroups.Models.CreateManagementGroupDetails Details { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public string Id { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public Azure.Core.ResourceType? ResourceType { get { throw null; } }
        public System.Guid? TenantId { get { throw null; } }
        Azure.ResourceManager.ManagementGroups.Models.ManagementGroupCreateOrUpdateContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupCreateOrUpdateContent>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupCreateOrUpdateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupCreateOrUpdateContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ManagementGroups.Models.ManagementGroupCreateOrUpdateContent System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupCreateOrUpdateContent>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupCreateOrUpdateContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ManagementGroupExpandType : System.IEquatable<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ManagementGroupExpandType(string value) { throw null; }
        public static Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType Ancestors { get { throw null; } }
        public static Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType Children { get { throw null; } }
        public static Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType Path { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType left, Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType left, Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ManagementGroupInfo : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupInfo>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupInfo>
    {
        internal ManagementGroupInfo() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPathElement> ManagementGroupAncestorChain { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> ManagementGroupAncestors { get { throw null; } }
        public Azure.ResourceManager.ManagementGroups.Models.ParentManagementGroupInfo Parent { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPathElement> Path { get { throw null; } }
        public string UpdatedBy { get { throw null; } }
        public System.DateTimeOffset? UpdatedOn { get { throw null; } }
        public int? Version { get { throw null; } }
        Azure.ResourceManager.ManagementGroups.Models.ManagementGroupInfo System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupInfo>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupInfo>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ManagementGroups.Models.ManagementGroupInfo System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupInfo>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupInfo>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagementGroupNameAvailabilityContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityContent>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityContent>
    {
        public ManagementGroupNameAvailabilityContent() { }
        public string Name { get { throw null; } set { } }
        public Azure.Core.ResourceType? ResourceType { get { throw null; } set { } }
        Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityContent>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityContent System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityContent>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagementGroupNameAvailabilityResult : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityResult>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityResult>
    {
        internal ManagementGroupNameAvailabilityResult() { }
        public string Message { get { throw null; } }
        public bool? NameAvailable { get { throw null; } }
        public Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameUnavailableReason? Reason { get { throw null; } }
        Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityResult System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityResult>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityResult>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityResult System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityResult>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityResult>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public enum ManagementGroupNameUnavailableReason
    {
        Invalid = 0,
        AlreadyExists = 1,
    }
    public partial class ManagementGroupParentCreateOptions : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupParentCreateOptions>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupParentCreateOptions>
    {
        public ManagementGroupParentCreateOptions() { }
        public string DisplayName { get { throw null; } }
        public string Id { get { throw null; } set { } }
        public string Name { get { throw null; } }
        Azure.ResourceManager.ManagementGroups.Models.ManagementGroupParentCreateOptions System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupParentCreateOptions>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupParentCreateOptions>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupParentCreateOptions>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ManagementGroups.Models.ManagementGroupParentCreateOptions System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupParentCreateOptions>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupParentCreateOptions>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagementGroupPatch : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPatch>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPatch>
    {
        public ManagementGroupPatch() { }
        public string DisplayName { get { throw null; } set { } }
        public string ParentGroupId { get { throw null; } set { } }
        Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPatch>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPatch System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPatch>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagementGroupPathElement : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPathElement>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPathElement>
    {
        internal ManagementGroupPathElement() { }
        public string DisplayName { get { throw null; } }
        public string Name { get { throw null; } }
        Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPathElement System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPathElement>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPathElement>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPathElement>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPathElement System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPathElement>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPathElement>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ParentManagementGroupInfo : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ParentManagementGroupInfo>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ParentManagementGroupInfo>
    {
        internal ParentManagementGroupInfo() { }
        public string DisplayName { get { throw null; } }
        public string Id { get { throw null; } }
        public string Name { get { throw null; } }
        Azure.ResourceManager.ManagementGroups.Models.ParentManagementGroupInfo System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ParentManagementGroupInfo>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.ManagementGroups.Models.ParentManagementGroupInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ParentManagementGroupInfo>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.ManagementGroups.Models.ParentManagementGroupInfo System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ParentManagementGroupInfo>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.ManagementGroups.Models.ParentManagementGroupInfo>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
}
namespace Azure.ResourceManager.Models
{
    public sealed partial class ArmPlan : System.IEquatable<Azure.ResourceManager.Models.ArmPlan>, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.ArmPlan>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.ArmPlan>
    {
        public ArmPlan(string name, string publisher, string product) { }
        public string Name { get { throw null; } set { } }
        public string Product { get { throw null; } set { } }
        public string PromotionCode { get { throw null; } set { } }
        public string Publisher { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
        public bool Equals(Azure.ResourceManager.Models.ArmPlan other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Models.ArmPlan left, Azure.ResourceManager.Models.ArmPlan right) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Models.ArmPlan left, Azure.ResourceManager.Models.ArmPlan right) { throw null; }
        Azure.ResourceManager.Models.ArmPlan System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.ArmPlan>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.ArmPlan>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.ArmPlan>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Models.ArmPlan System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.ArmPlan>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.ArmPlan>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public sealed partial class ArmSku : System.IEquatable<Azure.ResourceManager.Models.ArmSku>, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.ArmSku>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.ArmSku>
    {
        public ArmSku(string name) { }
        public int? Capacity { get { throw null; } set { } }
        public string Family { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Size { get { throw null; } set { } }
        public Azure.ResourceManager.Models.ArmSkuTier? Tier { get { throw null; } set { } }
        public bool Equals(Azure.ResourceManager.Models.ArmSku other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Models.ArmSku left, Azure.ResourceManager.Models.ArmSku right) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Models.ArmSku left, Azure.ResourceManager.Models.ArmSku right) { throw null; }
        Azure.ResourceManager.Models.ArmSku System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.ArmSku>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.ArmSku>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.ArmSku>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Models.ArmSku System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.ArmSku>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.ArmSku>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public enum ArmSkuTier
    {
        Free = 0,
        Basic = 1,
        Standard = 2,
        Premium = 3,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CreatedByType : System.IEquatable<Azure.ResourceManager.Models.CreatedByType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CreatedByType(string value) { throw null; }
        public static Azure.ResourceManager.Models.CreatedByType Application { get { throw null; } }
        public static Azure.ResourceManager.Models.CreatedByType Key { get { throw null; } }
        public static Azure.ResourceManager.Models.CreatedByType ManagedIdentity { get { throw null; } }
        public static Azure.ResourceManager.Models.CreatedByType User { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Models.CreatedByType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Models.CreatedByType left, Azure.ResourceManager.Models.CreatedByType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Models.CreatedByType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Models.CreatedByType left, Azure.ResourceManager.Models.CreatedByType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.ObsoleteAttribute("This type is obsolete and will be removed in a future release.", false)]
    public partial class EncryptionProperties : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.EncryptionProperties>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.EncryptionProperties>
    {
        public EncryptionProperties() { }
        public Azure.ResourceManager.Models.KeyVaultProperties KeyVaultProperties { get { throw null; } set { } }
        public Azure.ResourceManager.Models.EncryptionStatus? Status { get { throw null; } set { } }
        Azure.ResourceManager.Models.EncryptionProperties System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.EncryptionProperties>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.EncryptionProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.EncryptionProperties>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Models.EncryptionProperties System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.EncryptionProperties>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.EncryptionProperties>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.ObsoleteAttribute("This type is obsolete and will be removed in a future release.", false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EncryptionStatus : System.IEquatable<Azure.ResourceManager.Models.EncryptionStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EncryptionStatus(string value) { throw null; }
        public static Azure.ResourceManager.Models.EncryptionStatus Disabled { get { throw null; } }
        public static Azure.ResourceManager.Models.EncryptionStatus Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Models.EncryptionStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Models.EncryptionStatus left, Azure.ResourceManager.Models.EncryptionStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Models.EncryptionStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Models.EncryptionStatus left, Azure.ResourceManager.Models.EncryptionStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.ObsoleteAttribute("This type is obsolete and will be removed in a future release.", false)]
    public partial class KeyVaultProperties : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.KeyVaultProperties>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.KeyVaultProperties>
    {
        public KeyVaultProperties() { }
        public string Identity { get { throw null; } set { } }
        public string KeyIdentifier { get { throw null; } set { } }
        Azure.ResourceManager.Models.KeyVaultProperties System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.KeyVaultProperties>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.KeyVaultProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.KeyVaultProperties>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Models.KeyVaultProperties System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.KeyVaultProperties>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.KeyVaultProperties>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedServiceIdentity
    {
        public ManagedServiceIdentity(Azure.ResourceManager.Models.ManagedServiceIdentityType managedServiceIdentityType) { }
        public Azure.ResourceManager.Models.ManagedServiceIdentityType ManagedServiceIdentityType { get { throw null; } set { } }
        public System.Guid? PrincipalId { get { throw null; } }
        public System.Guid? TenantId { get { throw null; } }
        public System.Collections.Generic.IDictionary<Azure.Core.ResourceIdentifier, Azure.ResourceManager.Models.UserAssignedIdentity> UserAssignedIdentities { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ManagedServiceIdentityType : System.IEquatable<Azure.ResourceManager.Models.ManagedServiceIdentityType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ManagedServiceIdentityType(string value) { throw null; }
        public static Azure.ResourceManager.Models.ManagedServiceIdentityType None { get { throw null; } }
        public static Azure.ResourceManager.Models.ManagedServiceIdentityType SystemAssigned { get { throw null; } }
        public static Azure.ResourceManager.Models.ManagedServiceIdentityType SystemAssignedUserAssigned { get { throw null; } }
        public static Azure.ResourceManager.Models.ManagedServiceIdentityType UserAssigned { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Models.ManagedServiceIdentityType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Models.ManagedServiceIdentityType left, Azure.ResourceManager.Models.ManagedServiceIdentityType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Models.ManagedServiceIdentityType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Models.ManagedServiceIdentityType left, Azure.ResourceManager.Models.ManagedServiceIdentityType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class OperationStatusResult : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.OperationStatusResult>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.OperationStatusResult>
    {
        protected OperationStatusResult(Azure.Core.ResourceIdentifier id, string name, string status, float? percentComplete, System.DateTimeOffset? startOn, System.DateTimeOffset? endOn, System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Models.OperationStatusResult> operations, Azure.ResponseError error) { }
        public OperationStatusResult(string status) { }
        public System.DateTimeOffset? EndOn { get { throw null; } }
        public Azure.ResponseError Error { get { throw null; } }
        public Azure.Core.ResourceIdentifier Id { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Models.OperationStatusResult> Operations { get { throw null; } }
        public float? PercentComplete { get { throw null; } }
        public System.DateTimeOffset? StartOn { get { throw null; } }
        public string Status { get { throw null; } }
        Azure.ResourceManager.Models.OperationStatusResult System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.OperationStatusResult>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.OperationStatusResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.OperationStatusResult>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Models.OperationStatusResult System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.OperationStatusResult>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.OperationStatusResult>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class ResourceData
    {
        protected ResourceData() { }
        protected ResourceData(Azure.Core.ResourceIdentifier id, string name, Azure.Core.ResourceType resourceType, Azure.ResourceManager.Models.SystemData systemData) { }
        public Azure.Core.ResourceIdentifier Id { get { throw null; } }
        public string Name { get { throw null; } }
        public Azure.Core.ResourceType ResourceType { get { throw null; } }
        public Azure.ResourceManager.Models.SystemData SystemData { get { throw null; } }
    }
    public static partial class ResourceManagerModelFactory
    {
        public static Azure.ResourceManager.Resources.Models.ApiProfile ApiProfile(string profileVersion = null, string apiVersion = null) { throw null; }
        public static Azure.ResourceManager.Resources.Models.AvailabilityZoneMappings AvailabilityZoneMappings(string logicalZone = null, string physicalZone = null) { throw null; }
        public static Azure.ResourceManager.Resources.Models.AzureRoleDefinition AzureRoleDefinition(string id = null, string name = null, bool? isServiceRole = default(bool?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Permission> permissions = null, System.Collections.Generic.IEnumerable<string> scopes = null) { throw null; }
        public static Azure.ResourceManager.ManagementGroups.Models.CreateManagementGroupDetails CreateManagementGroupDetails(int? version = default(int?), System.DateTimeOffset? updatedOn = default(System.DateTimeOffset?), string updatedBy = null, Azure.ResourceManager.ManagementGroups.Models.ManagementGroupParentCreateOptions parent = null) { throw null; }
        public static Azure.ResourceManager.Resources.Models.DataManifestCustomResourceFunctionDefinition DataManifestCustomResourceFunctionDefinition(string name = null, Azure.Core.ResourceType? fullyQualifiedResourceType = default(Azure.Core.ResourceType?), System.Collections.Generic.IEnumerable<string> defaultProperties = null, bool? allowCustomProperties = default(bool?)) { throw null; }
        public static Azure.ResourceManager.Resources.DataPolicyManifestData DataPolicyManifestData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IEnumerable<string> namespaces = null, string policyMode = null, bool? isBuiltInOnly = default(bool?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.ResourceTypeAliases> resourceTypeAliases = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.DataPolicyManifestEffect> effects = null, System.Collections.Generic.IEnumerable<string> fieldValues = null, System.Collections.Generic.IEnumerable<string> standard = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.DataManifestCustomResourceFunctionDefinition> customDefinitions = null) { throw null; }
        public static Azure.ResourceManager.Resources.Models.DataPolicyManifestEffect DataPolicyManifestEffect(string name = null, System.BinaryData detailsSchema = null) { throw null; }
        public static Azure.ResourceManager.ManagementGroups.Models.DescendantData DescendantData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string displayName = null, Azure.Core.ResourceIdentifier parentId = null) { throw null; }
        public static Azure.ResourceManager.Resources.FeatureData FeatureData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string featureState = null) { throw null; }
        public static Azure.ResourceManager.Resources.GenericResourceData GenericResourceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.Resources.Models.ExtendedLocation extendedLocation = null, System.Collections.Generic.IDictionary<string, System.BinaryData> serializedAdditionalRawData = null, Azure.ResourceManager.Models.ArmPlan plan = null, System.BinaryData properties = null, string kind = null, string managedBy = null, Azure.ResourceManager.Resources.Models.ResourcesSku sku = null, Azure.ResourceManager.Models.ManagedServiceIdentity identity = null, System.DateTimeOffset? createdOn = default(System.DateTimeOffset?), System.DateTimeOffset? changedOn = default(System.DateTimeOffset?), string provisioningState = null) { throw null; }
        public static Azure.ResourceManager.Resources.Models.LocationExpanded LocationExpanded(string id, string subscriptionId, string name, Azure.ResourceManager.Resources.Models.LocationType? locationType, string displayName, string regionalDisplayName, Azure.ResourceManager.Resources.Models.LocationMetadata metadata) { throw null; }
        public static Azure.ResourceManager.Resources.Models.LocationExpanded LocationExpanded(string id = null, string subscriptionId = null, string name = null, Azure.ResourceManager.Resources.Models.LocationType? locationType = default(Azure.ResourceManager.Resources.Models.LocationType?), string displayName = null, string regionalDisplayName = null, Azure.ResourceManager.Resources.Models.LocationMetadata metadata = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.AvailabilityZoneMappings> availabilityZoneMappings = null) { throw null; }
        public static Azure.ResourceManager.Resources.Models.LocationMetadata LocationMetadata(Azure.ResourceManager.Resources.Models.RegionType? regionType = default(Azure.ResourceManager.Resources.Models.RegionType?), Azure.ResourceManager.Resources.Models.RegionCategory? regionCategory = default(Azure.ResourceManager.Resources.Models.RegionCategory?), string geography = null, string geographyGroup = null, double? longitude = default(double?), double? latitude = default(double?), string physicalLocation = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.PairedRegion> pairedRegions = null, string homeLocation = null) { throw null; }
        public static Azure.ResourceManager.Resources.Models.ManagedByTenant ManagedByTenant(System.Guid? tenantId = default(System.Guid?)) { throw null; }
        public static Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildInfo ManagementGroupChildInfo(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildType? childType = default(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildType?), string id = null, string name = null, string displayName = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildInfo> children = null) { throw null; }
        public static Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildOptions ManagementGroupChildOptions(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildType? childType = default(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildType?), string id = null, string name = null, string displayName = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildOptions> children = null) { throw null; }
        public static Azure.ResourceManager.ManagementGroups.Models.ManagementGroupCreateOrUpdateContent ManagementGroupCreateOrUpdateContent(string id = null, Azure.Core.ResourceType? resourceType = default(Azure.Core.ResourceType?), string name = null, System.Guid? tenantId = default(System.Guid?), string displayName = null, Azure.ResourceManager.ManagementGroups.Models.CreateManagementGroupDetails details = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildOptions> children = null) { throw null; }
        public static Azure.ResourceManager.ManagementGroups.ManagementGroupData ManagementGroupData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Guid? tenantId = default(System.Guid?), string displayName = null, Azure.ResourceManager.ManagementGroups.Models.ManagementGroupInfo details = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupChildInfo> children = null) { throw null; }
        public static Azure.ResourceManager.ManagementGroups.Models.ManagementGroupInfo ManagementGroupInfo(int? version = default(int?), System.DateTimeOffset? updatedOn = default(System.DateTimeOffset?), string updatedBy = null, Azure.ResourceManager.ManagementGroups.Models.ParentManagementGroupInfo parent = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPathElement> path = null, System.Collections.Generic.IEnumerable<string> managementGroupAncestors = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPathElement> managementGroupAncestorChain = null) { throw null; }
        public static Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameAvailabilityResult ManagementGroupNameAvailabilityResult(bool? nameAvailable = default(bool?), Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameUnavailableReason? reason = default(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupNameUnavailableReason?), string message = null) { throw null; }
        public static Azure.ResourceManager.ManagementGroups.Models.ManagementGroupParentCreateOptions ManagementGroupParentCreateOptions(string id = null, string name = null, string displayName = null) { throw null; }
        public static Azure.ResourceManager.ManagementGroups.Models.ManagementGroupPathElement ManagementGroupPathElement(string name = null, string displayName = null) { throw null; }
        public static Azure.ResourceManager.Resources.ManagementLockData ManagementLockData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Resources.Models.ManagementLockLevel level = default(Azure.ResourceManager.Resources.Models.ManagementLockLevel), string notes = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.ManagementLockOwner> owners = null) { throw null; }
        public static Azure.ResourceManager.Resources.Models.PairedRegion PairedRegion(string name = null, string id = null, string subscriptionId = null) { throw null; }
        public static Azure.ResourceManager.ManagementGroups.Models.ParentManagementGroupInfo ParentManagementGroupInfo(string id = null, string name = null, string displayName = null) { throw null; }
        public static Azure.ResourceManager.Resources.Models.Permission Permission(System.Collections.Generic.IEnumerable<string> allowedActions = null, System.Collections.Generic.IEnumerable<string> deniedActions = null, System.Collections.Generic.IEnumerable<string> allowedDataActions = null, System.Collections.Generic.IEnumerable<string> deniedDataActions = null) { throw null; }
        public static Azure.ResourceManager.Resources.PolicyAssignmentData PolicyAssignmentData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.Core.AzureLocation? location = default(Azure.Core.AzureLocation?), Azure.ResourceManager.Models.ManagedServiceIdentity managedIdentity = null, string displayName = null, string policyDefinitionId = null, string scope = null, System.Collections.Generic.IEnumerable<string> excludedScopes = null, System.Collections.Generic.IDictionary<string, Azure.ResourceManager.Resources.Models.ArmPolicyParameterValue> parameters = null, string description = null, System.BinaryData metadata = null, Azure.ResourceManager.Resources.Models.EnforcementMode? enforcementMode = default(Azure.ResourceManager.Resources.Models.EnforcementMode?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.NonComplianceMessage> nonComplianceMessages = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.ResourceSelector> resourceSelectors = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.PolicyOverride> overrides = null) { throw null; }
        public static Azure.ResourceManager.Resources.PolicyDefinitionData PolicyDefinitionData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Resources.Models.PolicyType? policyType = default(Azure.ResourceManager.Resources.Models.PolicyType?), string mode = null, string displayName = null, string description = null, System.BinaryData policyRule = null, System.BinaryData metadata = null, System.Collections.Generic.IDictionary<string, Azure.ResourceManager.Resources.Models.ArmPolicyParameter> parameters = null) { throw null; }
        public static Azure.ResourceManager.Resources.PolicySetDefinitionData PolicySetDefinitionData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Resources.Models.PolicyType? policyType = default(Azure.ResourceManager.Resources.Models.PolicyType?), string displayName = null, string description = null, System.BinaryData metadata = null, System.Collections.Generic.IDictionary<string, Azure.ResourceManager.Resources.Models.ArmPolicyParameter> parameters = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.PolicyDefinitionReference> policyDefinitions = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.PolicyDefinitionGroup> policyDefinitionGroups = null) { throw null; }
        public static Azure.ResourceManager.Resources.Models.PredefinedTag PredefinedTag(string id = null, string tagName = null, Azure.ResourceManager.Resources.Models.PredefinedTagCount count = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.PredefinedTagValue> values = null) { throw null; }
        public static Azure.ResourceManager.Resources.Models.PredefinedTagCount PredefinedTagCount(string predefinedTagCountType = null, int? value = default(int?)) { throw null; }
        public static Azure.ResourceManager.Resources.Models.PredefinedTagValue PredefinedTagValue(string id = null, string tagValue = null, Azure.ResourceManager.Resources.Models.PredefinedTagCount count = null) { throw null; }
        public static Azure.ResourceManager.Resources.Models.ProviderExtendedLocation ProviderExtendedLocation(Azure.Core.AzureLocation? location = default(Azure.Core.AzureLocation?), string providerExtendedLocationType = null, System.Collections.Generic.IEnumerable<string> extendedLocations = null) { throw null; }
        public static Azure.ResourceManager.Resources.Models.ProviderPermission ProviderPermission(string applicationId = null, Azure.ResourceManager.Resources.Models.AzureRoleDefinition roleDefinition = null, Azure.ResourceManager.Resources.Models.AzureRoleDefinition managedByRoleDefinition = null, Azure.ResourceManager.Resources.Models.ProviderAuthorizationConsentState? providerAuthorizationConsentState = default(Azure.ResourceManager.Resources.Models.ProviderAuthorizationConsentState?)) { throw null; }
        public static Azure.ResourceManager.Resources.Models.ProviderResourceType ProviderResourceType(string resourceType = null, System.Collections.Generic.IEnumerable<string> locations = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.ProviderExtendedLocation> locationMappings = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.ResourceTypeAlias> aliases = null, System.Collections.Generic.IEnumerable<string> apiVersions = null, string defaultApiVersion = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.ZoneMapping> zoneMappings = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.ApiProfile> apiProfiles = null, string capabilities = null, System.Collections.Generic.IReadOnlyDictionary<string, string> properties = null) { throw null; }
        public static Azure.ResourceManager.Resources.ResourceGroupData ResourceGroupData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), string resourceGroupProvisioningState = null, string managedBy = null) { throw null; }
        public static Azure.ResourceManager.Resources.Models.ResourceGroupExportResult ResourceGroupExportResult(System.BinaryData template = null, Azure.ResponseError error = null) { throw null; }
        public static Azure.ResourceManager.Resources.ResourceProviderData ResourceProviderData(Azure.Core.ResourceIdentifier id = null, string @namespace = null, string registrationState = null, string registrationPolicy = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.ProviderResourceType> resourceTypes = null, Azure.ResourceManager.Resources.Models.ProviderAuthorizationConsentState? providerAuthorizationConsentState = default(Azure.ResourceManager.Resources.Models.ProviderAuthorizationConsentState?)) { throw null; }
        public static Azure.ResourceManager.Resources.Models.ResourceTypeAlias ResourceTypeAlias(string name = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPath> paths = null, Azure.ResourceManager.Resources.Models.ResourceTypeAliasType? aliasType = default(Azure.ResourceManager.Resources.Models.ResourceTypeAliasType?), string defaultPath = null, Azure.ResourceManager.Resources.Models.ResourceTypeAliasPattern defaultPattern = null, Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathMetadata defaultMetadata = null) { throw null; }
        public static Azure.ResourceManager.Resources.Models.ResourceTypeAliases ResourceTypeAliases(string resourceType = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.ResourceTypeAlias> aliases = null) { throw null; }
        public static Azure.ResourceManager.Resources.Models.ResourceTypeAliasPath ResourceTypeAliasPath(string path = null, System.Collections.Generic.IEnumerable<string> apiVersions = null, Azure.ResourceManager.Resources.Models.ResourceTypeAliasPattern pattern = null, Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathMetadata metadata = null) { throw null; }
        public static Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathMetadata ResourceTypeAliasPathMetadata(Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathTokenType? tokenType = default(Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathTokenType?), Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathAttributes? attributes = default(Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathAttributes?)) { throw null; }
        public static Azure.ResourceManager.Resources.Models.ResourceTypeAliasPattern ResourceTypeAliasPattern(string phrase = null, string variable = null, Azure.ResourceManager.Resources.Models.ResourceTypeAliasPatternType? patternType = default(Azure.ResourceManager.Resources.Models.ResourceTypeAliasPatternType?)) { throw null; }
        public static Azure.ResourceManager.Resources.Models.SubResource SubResource(Azure.Core.ResourceIdentifier id = null) { throw null; }
        public static Azure.ResourceManager.Resources.SubscriptionData SubscriptionData(Azure.Core.ResourceIdentifier id = null, string subscriptionId = null, string displayName = null, System.Guid? tenantId = default(System.Guid?), Azure.ResourceManager.Resources.Models.SubscriptionState? state = default(Azure.ResourceManager.Resources.Models.SubscriptionState?), Azure.ResourceManager.Resources.Models.SubscriptionPolicies subscriptionPolicies = null, string authorizationSource = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.ManagedByTenant> managedByTenants = null, System.Collections.Generic.IReadOnlyDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Resources.Models.SubscriptionPolicies SubscriptionPolicies(string locationPlacementId = null, string quotaId = null, Azure.ResourceManager.Resources.Models.SpendingLimit? spendingLimit = default(Azure.ResourceManager.Resources.Models.SpendingLimit?)) { throw null; }
        public static Azure.ResourceManager.Resources.TagResourceData TagResourceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tagValues = null) { throw null; }
        public static Azure.ResourceManager.Resources.TenantData TenantData(string id = null, System.Guid? tenantId = default(System.Guid?), Azure.ResourceManager.Resources.Models.TenantCategory? tenantCategory = default(Azure.ResourceManager.Resources.Models.TenantCategory?), string country = null, string countryCode = null, string displayName = null, System.Collections.Generic.IEnumerable<string> domains = null, string defaultDomain = null, string tenantType = null, System.Uri tenantBrandingLogoUri = null) { throw null; }
        public static Azure.ResourceManager.Resources.Models.TenantResourceProvider TenantResourceProvider(string @namespace = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.ProviderResourceType> resourceTypes = null) { throw null; }
        public static Azure.ResourceManager.Resources.Models.TrackedResourceExtendedData TrackedResourceExtendedData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.Resources.Models.ExtendedLocation extendedLocation = null) { throw null; }
        public static Azure.ResourceManager.Resources.Models.WritableSubResource WritableSubResource(Azure.Core.ResourceIdentifier id = null) { throw null; }
        public static Azure.ResourceManager.Resources.Models.ZoneMapping ZoneMapping(Azure.Core.AzureLocation? location = default(Azure.Core.AzureLocation?), System.Collections.Generic.IEnumerable<string> zones = null) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.ObsoleteAttribute("This type is obsolete and will be removed in a future release.", false)]
    public partial class SystemAssignedServiceIdentity : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.SystemAssignedServiceIdentity>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.SystemAssignedServiceIdentity>
    {
        public SystemAssignedServiceIdentity(Azure.ResourceManager.Models.SystemAssignedServiceIdentityType systemAssignedServiceIdentityType) { }
        public System.Guid? PrincipalId { get { throw null; } }
        public Azure.ResourceManager.Models.SystemAssignedServiceIdentityType SystemAssignedServiceIdentityType { get { throw null; } set { } }
        public System.Guid? TenantId { get { throw null; } }
        Azure.ResourceManager.Models.SystemAssignedServiceIdentity System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.SystemAssignedServiceIdentity>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.SystemAssignedServiceIdentity>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.SystemAssignedServiceIdentity>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Models.SystemAssignedServiceIdentity System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.SystemAssignedServiceIdentity>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.SystemAssignedServiceIdentity>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.ObsoleteAttribute("This type is obsolete and will be removed in a future release.", false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SystemAssignedServiceIdentityType : System.IEquatable<Azure.ResourceManager.Models.SystemAssignedServiceIdentityType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SystemAssignedServiceIdentityType(string value) { throw null; }
        public static Azure.ResourceManager.Models.SystemAssignedServiceIdentityType None { get { throw null; } }
        public static Azure.ResourceManager.Models.SystemAssignedServiceIdentityType SystemAssigned { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Models.SystemAssignedServiceIdentityType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Models.SystemAssignedServiceIdentityType left, Azure.ResourceManager.Models.SystemAssignedServiceIdentityType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Models.SystemAssignedServiceIdentityType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Models.SystemAssignedServiceIdentityType left, Azure.ResourceManager.Models.SystemAssignedServiceIdentityType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SystemData : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.SystemData>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.SystemData>
    {
        public SystemData() { }
        public string CreatedBy { get { throw null; } }
        public Azure.ResourceManager.Models.CreatedByType? CreatedByType { get { throw null; } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public string LastModifiedBy { get { throw null; } }
        public Azure.ResourceManager.Models.CreatedByType? LastModifiedByType { get { throw null; } }
        public System.DateTimeOffset? LastModifiedOn { get { throw null; } }
        Azure.ResourceManager.Models.SystemData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.SystemData>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.SystemData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.SystemData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Models.SystemData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.SystemData>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.SystemData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class TrackedResourceData : Azure.ResourceManager.Models.ResourceData
    {
        protected TrackedResourceData() { }
        protected TrackedResourceData(Azure.Core.AzureLocation location) { }
        protected TrackedResourceData(Azure.Core.ResourceIdentifier id, string name, Azure.Core.ResourceType resourceType, Azure.ResourceManager.Models.SystemData systemData, System.Collections.Generic.IDictionary<string, string> tags, Azure.Core.AzureLocation location) { }
        public Azure.Core.AzureLocation Location { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
    }
    public partial class UserAssignedIdentity : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.UserAssignedIdentity>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.UserAssignedIdentity>
    {
        public UserAssignedIdentity() { }
        public System.Guid? ClientId { get { throw null; } }
        public System.Guid? PrincipalId { get { throw null; } }
        Azure.ResourceManager.Models.UserAssignedIdentity System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.UserAssignedIdentity>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Models.UserAssignedIdentity>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.UserAssignedIdentity>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Models.UserAssignedIdentity System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.UserAssignedIdentity>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Models.UserAssignedIdentity>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
}
namespace Azure.ResourceManager.Resources
{
    public partial class ArmRestApiCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.Models.ArmRestApi>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.ArmRestApi>, System.Collections.IEnumerable
    {
        protected ArmRestApiCollection() { }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.Models.ArmRestApi> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.Models.ArmRestApi> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Resources.Models.ArmRestApi> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.Models.ArmRestApi>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Resources.Models.ArmRestApi> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.ArmRestApi>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DataPolicyManifestCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.DataPolicyManifestResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.DataPolicyManifestResource>, System.Collections.IEnumerable
    {
        protected DataPolicyManifestCollection() { }
        public virtual Azure.Response<bool> Exists(string policyMode, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string policyMode, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.DataPolicyManifestResource> Get(string policyMode, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.DataPolicyManifestResource> GetAll(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.DataPolicyManifestResource> GetAllAsync(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.DataPolicyManifestResource>> GetAsync(string policyMode, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Resources.DataPolicyManifestResource> GetIfExists(string policyMode, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Resources.DataPolicyManifestResource>> GetIfExistsAsync(string policyMode, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Resources.DataPolicyManifestResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.DataPolicyManifestResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Resources.DataPolicyManifestResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.DataPolicyManifestResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DataPolicyManifestData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.DataPolicyManifestData>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.DataPolicyManifestData>
    {
        internal DataPolicyManifestData() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.DataManifestCustomResourceFunctionDefinition> CustomDefinitions { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.DataPolicyManifestEffect> Effects { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> FieldValues { get { throw null; } }
        public bool? IsBuiltInOnly { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Namespaces { get { throw null; } }
        public string PolicyMode { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.ResourceTypeAliases> ResourceTypeAliases { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Standard { get { throw null; } }
        Azure.ResourceManager.Resources.DataPolicyManifestData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.DataPolicyManifestData>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.DataPolicyManifestData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.DataPolicyManifestData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.DataPolicyManifestData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.DataPolicyManifestData>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.DataPolicyManifestData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DataPolicyManifestResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DataPolicyManifestResource() { }
        public virtual Azure.ResourceManager.Resources.DataPolicyManifestData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string policyMode) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.DataPolicyManifestResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.DataPolicyManifestResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class FeatureCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.FeatureResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.FeatureResource>, System.Collections.IEnumerable
    {
        protected FeatureCollection() { }
        public virtual Azure.Response<bool> Exists(string featureName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string featureName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.FeatureResource> Get(string featureName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.FeatureResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.FeatureResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.FeatureResource>> GetAsync(string featureName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Resources.FeatureResource> GetIfExists(string featureName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Resources.FeatureResource>> GetIfExistsAsync(string featureName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Resources.FeatureResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.FeatureResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Resources.FeatureResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.FeatureResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class FeatureData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.FeatureData>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.FeatureData>
    {
        internal FeatureData() { }
        public string FeatureState { get { throw null; } }
        Azure.ResourceManager.Resources.FeatureData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.FeatureData>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.FeatureData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.FeatureData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.FeatureData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.FeatureData>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.FeatureData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class FeatureResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected FeatureResource() { }
        public virtual Azure.ResourceManager.Resources.FeatureData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceProviderNamespace, string featureName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.FeatureResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.FeatureResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.FeatureResource> Register(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.FeatureResource>> RegisterAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.FeatureResource> Unregister(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.FeatureResource>> UnregisterAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class GenericResource : Azure.ResourceManager.ArmResource
    {
        protected GenericResource() { }
        public virtual Azure.ResourceManager.Resources.GenericResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Resources.GenericResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.GenericResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.GenericResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.GenericResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.GenericResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.GenericResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.GenericResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.GenericResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.GenericResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.GenericResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.GenericResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.GenericResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class GenericResourceCollection : Azure.ResourceManager.ArmCollection
    {
        protected GenericResourceCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.GenericResource> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.Core.ResourceIdentifier resourceId, Azure.ResourceManager.Resources.GenericResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.GenericResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.Core.ResourceIdentifier resourceId, Azure.ResourceManager.Resources.GenericResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(Azure.Core.ResourceIdentifier resourceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(Azure.Core.ResourceIdentifier resourceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.GenericResource> Get(Azure.Core.ResourceIdentifier resourceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.GenericResource>> GetAsync(Azure.Core.ResourceIdentifier resourceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class GenericResourceData : Azure.ResourceManager.Resources.Models.TrackedResourceExtendedData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.GenericResourceData>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.GenericResourceData>
    {
        public GenericResourceData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public System.DateTimeOffset? ChangedOn { get { throw null; } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public string Kind { get { throw null; } set { } }
        public string ManagedBy { get { throw null; } set { } }
        public Azure.ResourceManager.Models.ArmPlan Plan { get { throw null; } set { } }
        public System.BinaryData Properties { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Resources.Models.ResourcesSku Sku { get { throw null; } set { } }
        Azure.ResourceManager.Resources.GenericResourceData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.GenericResourceData>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.GenericResourceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.GenericResourceData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.GenericResourceData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.GenericResourceData>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.GenericResourceData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagementGroupPolicyDefinitionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.ManagementGroupPolicyDefinitionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.ManagementGroupPolicyDefinitionResource>, System.Collections.IEnumerable
    {
        protected ManagementGroupPolicyDefinitionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.ManagementGroupPolicyDefinitionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string policyDefinitionName, Azure.ResourceManager.Resources.PolicyDefinitionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.ManagementGroupPolicyDefinitionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string policyDefinitionName, Azure.ResourceManager.Resources.PolicyDefinitionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.ManagementGroupPolicyDefinitionResource> Get(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.ManagementGroupPolicyDefinitionResource> GetAll(string filter = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.ManagementGroupPolicyDefinitionResource> GetAllAsync(string filter = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.ManagementGroupPolicyDefinitionResource>> GetAsync(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Resources.ManagementGroupPolicyDefinitionResource> GetIfExists(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Resources.ManagementGroupPolicyDefinitionResource>> GetIfExistsAsync(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Resources.ManagementGroupPolicyDefinitionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.ManagementGroupPolicyDefinitionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Resources.ManagementGroupPolicyDefinitionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.ManagementGroupPolicyDefinitionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ManagementGroupPolicyDefinitionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ManagementGroupPolicyDefinitionResource() { }
        public virtual Azure.ResourceManager.Resources.PolicyDefinitionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string managementGroupId, string policyDefinitionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.ManagementGroupPolicyDefinitionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.ManagementGroupPolicyDefinitionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.ManagementGroupPolicyDefinitionResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.PolicyDefinitionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.ManagementGroupPolicyDefinitionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.PolicyDefinitionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ManagementGroupPolicySetDefinitionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.ManagementGroupPolicySetDefinitionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.ManagementGroupPolicySetDefinitionResource>, System.Collections.IEnumerable
    {
        protected ManagementGroupPolicySetDefinitionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.ManagementGroupPolicySetDefinitionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string policySetDefinitionName, Azure.ResourceManager.Resources.PolicySetDefinitionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.ManagementGroupPolicySetDefinitionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string policySetDefinitionName, Azure.ResourceManager.Resources.PolicySetDefinitionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.ManagementGroupPolicySetDefinitionResource> Get(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.ManagementGroupPolicySetDefinitionResource> GetAll(string filter = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.ManagementGroupPolicySetDefinitionResource> GetAllAsync(string filter = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.ManagementGroupPolicySetDefinitionResource>> GetAsync(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Resources.ManagementGroupPolicySetDefinitionResource> GetIfExists(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Resources.ManagementGroupPolicySetDefinitionResource>> GetIfExistsAsync(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Resources.ManagementGroupPolicySetDefinitionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.ManagementGroupPolicySetDefinitionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Resources.ManagementGroupPolicySetDefinitionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.ManagementGroupPolicySetDefinitionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ManagementGroupPolicySetDefinitionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ManagementGroupPolicySetDefinitionResource() { }
        public virtual Azure.ResourceManager.Resources.PolicySetDefinitionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string managementGroupId, string policySetDefinitionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.ManagementGroupPolicySetDefinitionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.ManagementGroupPolicySetDefinitionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.ManagementGroupPolicySetDefinitionResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.PolicySetDefinitionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.ManagementGroupPolicySetDefinitionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.PolicySetDefinitionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ManagementLockCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.ManagementLockResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.ManagementLockResource>, System.Collections.IEnumerable
    {
        protected ManagementLockCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.ManagementLockResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string lockName, Azure.ResourceManager.Resources.ManagementLockData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.ManagementLockResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string lockName, Azure.ResourceManager.Resources.ManagementLockData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string lockName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string lockName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.ManagementLockResource> Get(string lockName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.ManagementLockResource> GetAll(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.ManagementLockResource> GetAllAsync(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.ManagementLockResource>> GetAsync(string lockName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Resources.ManagementLockResource> GetIfExists(string lockName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Resources.ManagementLockResource>> GetIfExistsAsync(string lockName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Resources.ManagementLockResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.ManagementLockResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Resources.ManagementLockResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.ManagementLockResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ManagementLockData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.ManagementLockData>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.ManagementLockData>
    {
        public ManagementLockData(Azure.ResourceManager.Resources.Models.ManagementLockLevel level) { }
        public Azure.ResourceManager.Resources.Models.ManagementLockLevel Level { get { throw null; } set { } }
        public string Notes { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.ManagementLockOwner> Owners { get { throw null; } }
        Azure.ResourceManager.Resources.ManagementLockData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.ManagementLockData>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.ManagementLockData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.ManagementLockData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.ManagementLockData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.ManagementLockData>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.ManagementLockData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagementLockResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ManagementLockResource() { }
        public virtual Azure.ResourceManager.Resources.ManagementLockData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string scope, string lockName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.ManagementLockResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.ManagementLockResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.ManagementLockResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.ManagementLockData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.ManagementLockResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.ManagementLockData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class PolicyAssignmentCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.PolicyAssignmentResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.PolicyAssignmentResource>, System.Collections.IEnumerable
    {
        protected PolicyAssignmentCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.PolicyAssignmentResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string policyAssignmentName, Azure.ResourceManager.Resources.PolicyAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.PolicyAssignmentResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string policyAssignmentName, Azure.ResourceManager.Resources.PolicyAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string policyAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string policyAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.PolicyAssignmentResource> Get(string policyAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.PolicyAssignmentResource> GetAll(string filter = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.PolicyAssignmentResource> GetAllAsync(string filter = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.PolicyAssignmentResource>> GetAsync(string policyAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Resources.PolicyAssignmentResource> GetIfExists(string policyAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Resources.PolicyAssignmentResource>> GetIfExistsAsync(string policyAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Resources.PolicyAssignmentResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.PolicyAssignmentResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Resources.PolicyAssignmentResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.PolicyAssignmentResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class PolicyAssignmentData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.PolicyAssignmentData>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.PolicyAssignmentData>
    {
        public PolicyAssignmentData() { }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public Azure.ResourceManager.Resources.Models.EnforcementMode? EnforcementMode { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> ExcludedScopes { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This property is obsolete and will be removed in a future release. Please use ManagedIdentity.", false)]
        public Azure.ResourceManager.Models.SystemAssignedServiceIdentity Identity { get { throw null; } set { } }
        public Azure.Core.AzureLocation? Location { get { throw null; } set { } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity ManagedIdentity { get { throw null; } set { } }
        public System.BinaryData Metadata { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.NonComplianceMessage> NonComplianceMessages { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.PolicyOverride> Overrides { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.Resources.Models.ArmPolicyParameterValue> Parameters { get { throw null; } }
        public string PolicyDefinitionId { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.ResourceSelector> ResourceSelectors { get { throw null; } }
        public string Scope { get { throw null; } }
        Azure.ResourceManager.Resources.PolicyAssignmentData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.PolicyAssignmentData>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.PolicyAssignmentData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.PolicyAssignmentData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.PolicyAssignmentData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.PolicyAssignmentData>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.PolicyAssignmentData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PolicyAssignmentResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected PolicyAssignmentResource() { }
        public virtual Azure.ResourceManager.Resources.PolicyAssignmentData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string scope, string policyAssignmentName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.PolicyAssignmentResource> Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.PolicyAssignmentResource>> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.PolicyAssignmentResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.PolicyAssignmentResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.PolicyAssignmentResource> Update(Azure.ResourceManager.Resources.Models.PolicyAssignmentPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.PolicyAssignmentResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.PolicyAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.PolicyAssignmentResource>> UpdateAsync(Azure.ResourceManager.Resources.Models.PolicyAssignmentPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.PolicyAssignmentResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.PolicyAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class PolicyDefinitionData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.PolicyDefinitionData>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.PolicyDefinitionData>
    {
        public PolicyDefinitionData() { }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public System.BinaryData Metadata { get { throw null; } set { } }
        public string Mode { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.Resources.Models.ArmPolicyParameter> Parameters { get { throw null; } }
        public System.BinaryData PolicyRule { get { throw null; } set { } }
        public Azure.ResourceManager.Resources.Models.PolicyType? PolicyType { get { throw null; } set { } }
        Azure.ResourceManager.Resources.PolicyDefinitionData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.PolicyDefinitionData>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.PolicyDefinitionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.PolicyDefinitionData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.PolicyDefinitionData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.PolicyDefinitionData>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.PolicyDefinitionData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PolicySetDefinitionData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.PolicySetDefinitionData>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.PolicySetDefinitionData>
    {
        public PolicySetDefinitionData() { }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public System.BinaryData Metadata { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.Resources.Models.ArmPolicyParameter> Parameters { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.PolicyDefinitionGroup> PolicyDefinitionGroups { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.PolicyDefinitionReference> PolicyDefinitions { get { throw null; } }
        public Azure.ResourceManager.Resources.Models.PolicyType? PolicyType { get { throw null; } set { } }
        Azure.ResourceManager.Resources.PolicySetDefinitionData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.PolicySetDefinitionData>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.PolicySetDefinitionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.PolicySetDefinitionData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.PolicySetDefinitionData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.PolicySetDefinitionData>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.PolicySetDefinitionData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResourceGroupCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.ResourceGroupResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.ResourceGroupResource>, System.Collections.IEnumerable
    {
        protected ResourceGroupCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.ResourceGroupResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string resourceGroupName, Azure.ResourceManager.Resources.ResourceGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.ResourceGroupResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string resourceGroupName, Azure.ResourceManager.Resources.ResourceGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.ResourceGroupResource> Get(string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.ResourceGroupResource> GetAll(string filter = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.ResourceGroupResource> GetAllAsync(string filter = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.ResourceGroupResource>> GetAsync(string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Resources.ResourceGroupResource> GetIfExists(string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Resources.ResourceGroupResource>> GetIfExistsAsync(string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Resources.ResourceGroupResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.ResourceGroupResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Resources.ResourceGroupResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.ResourceGroupResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ResourceGroupData : Azure.ResourceManager.Models.TrackedResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.ResourceGroupData>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.ResourceGroupData>
    {
        public ResourceGroupData(Azure.Core.AzureLocation location) { }
        public string ManagedBy { get { throw null; } set { } }
        public string ResourceGroupProvisioningState { get { throw null; } }
        Azure.ResourceManager.Resources.ResourceGroupData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.ResourceGroupData>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.ResourceGroupData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.ResourceGroupData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.ResourceGroupData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.ResourceGroupData>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.ResourceGroupData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ResourceGroupResource() { }
        public virtual Azure.ResourceManager.Resources.ResourceGroupData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Resources.ResourceGroupResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.ResourceGroupResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, string forceDeletionTypes = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, string forceDeletionTypes = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.Models.ResourceGroupExportResult> ExportTemplate(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.Models.ExportTemplate exportTemplate, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.Models.ResourceGroupExportResult>> ExportTemplateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.Models.ExportTemplate exportTemplate, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.ResourceGroupResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.ResourceGroupResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.GenericResource> GetGenericResources(string filter = null, string expand = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.GenericResource> GetGenericResourcesAsync(string filter = null, string expand = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation MoveResources(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.Models.ResourcesMoveContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> MoveResourcesAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.Models.ResourcesMoveContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.ResourceGroupResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.ResourceGroupResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.ResourceGroupResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.ResourceGroupResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.ResourceGroupResource> Update(Azure.ResourceManager.Resources.Models.ResourceGroupPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.ResourceGroupResource>> UpdateAsync(Azure.ResourceManager.Resources.Models.ResourceGroupPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation ValidateMoveResources(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.Models.ResourcesMoveContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> ValidateMoveResourcesAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.Models.ResourcesMoveContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ResourceProviderCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.ResourceProviderResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.ResourceProviderResource>, System.Collections.IEnumerable
    {
        protected ResourceProviderCollection() { }
        public virtual Azure.Response<bool> Exists(string resourceProviderNamespace, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string resourceProviderNamespace, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.ResourceProviderResource> Get(string resourceProviderNamespace, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This method is obsolete as the `top` parameter is not supported by service and will be removed in a future release.", false)]
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.ResourceProviderResource> GetAll(int? top, string expand, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.ResourceProviderResource> GetAll(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This method is obsolete as the `top` parameter is not supported by service and will be removed in a future release.", false)]
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.ResourceProviderResource> GetAllAsync(int? top, string expand, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.ResourceProviderResource> GetAllAsync(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.ResourceProviderResource>> GetAsync(string resourceProviderNamespace, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Resources.ResourceProviderResource> GetIfExists(string resourceProviderNamespace, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Resources.ResourceProviderResource>> GetIfExistsAsync(string resourceProviderNamespace, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Resources.ResourceProviderResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.ResourceProviderResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Resources.ResourceProviderResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.ResourceProviderResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ResourceProviderData : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.ResourceProviderData>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.ResourceProviderData>
    {
        public ResourceProviderData() { }
        public Azure.Core.ResourceIdentifier Id { get { throw null; } }
        public string Namespace { get { throw null; } }
        public Azure.ResourceManager.Resources.Models.ProviderAuthorizationConsentState? ProviderAuthorizationConsentState { get { throw null; } }
        public string RegistrationPolicy { get { throw null; } }
        public string RegistrationState { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.ProviderResourceType> ResourceTypes { get { throw null; } }
        Azure.ResourceManager.Resources.ResourceProviderData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.ResourceProviderData>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.ResourceProviderData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.ResourceProviderData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.ResourceProviderData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.ResourceProviderData>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.ResourceProviderData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResourceProviderResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ResourceProviderResource() { }
        public virtual Azure.ResourceManager.Resources.ResourceProviderData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceProviderNamespace) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.ResourceProviderResource> Get(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.ResourceProviderResource>> GetAsync(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.FeatureResource> GetFeature(string featureName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.FeatureResource>> GetFeatureAsync(string featureName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Resources.FeatureCollection GetFeatures() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.Models.ProviderResourceType> GetProviderResourceTypes(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.Models.ProviderResourceType> GetProviderResourceTypesAsync(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.Models.ProviderPermission> ProviderPermissions(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.Models.ProviderPermission> ProviderPermissionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.ResourceProviderResource> Register(Azure.ResourceManager.Resources.Models.ProviderRegistrationContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.ResourceProviderResource>> RegisterAsync(Azure.ResourceManager.Resources.Models.ProviderRegistrationContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.ResourceProviderResource> Unregister(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.ResourceProviderResource>> UnregisterAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SubscriptionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.SubscriptionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.SubscriptionResource>, System.Collections.IEnumerable
    {
        protected SubscriptionCollection() { }
        public virtual Azure.Response<bool> Exists(string subscriptionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string subscriptionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.SubscriptionResource> Get(string subscriptionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.SubscriptionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.SubscriptionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.SubscriptionResource>> GetAsync(string subscriptionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Resources.SubscriptionResource> GetIfExists(string subscriptionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Resources.SubscriptionResource>> GetIfExistsAsync(string subscriptionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Resources.SubscriptionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.SubscriptionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Resources.SubscriptionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.SubscriptionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SubscriptionData : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.SubscriptionData>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.SubscriptionData>
    {
        internal SubscriptionData() { }
        public string AuthorizationSource { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public virtual Azure.Core.ResourceIdentifier Id { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.ManagedByTenant> ManagedByTenants { get { throw null; } }
        public Azure.ResourceManager.Resources.Models.SubscriptionState? State { get { throw null; } }
        public string SubscriptionId { get { throw null; } }
        public Azure.ResourceManager.Resources.Models.SubscriptionPolicies SubscriptionPolicies { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> Tags { get { throw null; } }
        public System.Guid? TenantId { get { throw null; } }
        Azure.ResourceManager.Resources.SubscriptionData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.SubscriptionData>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.SubscriptionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.SubscriptionData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.SubscriptionData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.SubscriptionData>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.SubscriptionData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SubscriptionPolicyDefinitionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.SubscriptionPolicyDefinitionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.SubscriptionPolicyDefinitionResource>, System.Collections.IEnumerable
    {
        protected SubscriptionPolicyDefinitionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.SubscriptionPolicyDefinitionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string policyDefinitionName, Azure.ResourceManager.Resources.PolicyDefinitionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.SubscriptionPolicyDefinitionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string policyDefinitionName, Azure.ResourceManager.Resources.PolicyDefinitionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.SubscriptionPolicyDefinitionResource> Get(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.SubscriptionPolicyDefinitionResource> GetAll(string filter = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.SubscriptionPolicyDefinitionResource> GetAllAsync(string filter = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.SubscriptionPolicyDefinitionResource>> GetAsync(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Resources.SubscriptionPolicyDefinitionResource> GetIfExists(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Resources.SubscriptionPolicyDefinitionResource>> GetIfExistsAsync(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Resources.SubscriptionPolicyDefinitionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.SubscriptionPolicyDefinitionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Resources.SubscriptionPolicyDefinitionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.SubscriptionPolicyDefinitionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SubscriptionPolicyDefinitionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SubscriptionPolicyDefinitionResource() { }
        public virtual Azure.ResourceManager.Resources.PolicyDefinitionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string policyDefinitionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.SubscriptionPolicyDefinitionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.SubscriptionPolicyDefinitionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.SubscriptionPolicyDefinitionResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.PolicyDefinitionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.SubscriptionPolicyDefinitionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.PolicyDefinitionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SubscriptionPolicySetDefinitionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.SubscriptionPolicySetDefinitionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.SubscriptionPolicySetDefinitionResource>, System.Collections.IEnumerable
    {
        protected SubscriptionPolicySetDefinitionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.SubscriptionPolicySetDefinitionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string policySetDefinitionName, Azure.ResourceManager.Resources.PolicySetDefinitionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.SubscriptionPolicySetDefinitionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string policySetDefinitionName, Azure.ResourceManager.Resources.PolicySetDefinitionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.SubscriptionPolicySetDefinitionResource> Get(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.SubscriptionPolicySetDefinitionResource> GetAll(string filter = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.SubscriptionPolicySetDefinitionResource> GetAllAsync(string filter = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.SubscriptionPolicySetDefinitionResource>> GetAsync(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Resources.SubscriptionPolicySetDefinitionResource> GetIfExists(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Resources.SubscriptionPolicySetDefinitionResource>> GetIfExistsAsync(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Resources.SubscriptionPolicySetDefinitionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.SubscriptionPolicySetDefinitionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Resources.SubscriptionPolicySetDefinitionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.SubscriptionPolicySetDefinitionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SubscriptionPolicySetDefinitionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SubscriptionPolicySetDefinitionResource() { }
        public virtual Azure.ResourceManager.Resources.PolicySetDefinitionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string policySetDefinitionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.SubscriptionPolicySetDefinitionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.SubscriptionPolicySetDefinitionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.SubscriptionPolicySetDefinitionResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.PolicySetDefinitionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.SubscriptionPolicySetDefinitionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.PolicySetDefinitionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SubscriptionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SubscriptionResource() { }
        public virtual Azure.ResourceManager.Resources.SubscriptionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Resources.Models.PredefinedTag> CreateOrUpdatePredefinedTag(string tagName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.Models.PredefinedTag>> CreateOrUpdatePredefinedTagAsync(string tagName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.Models.PredefinedTagValue> CreateOrUpdatePredefinedTagValue(string tagName, string tagValue, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.Models.PredefinedTagValue>> CreateOrUpdatePredefinedTagValueAsync(string tagName, string tagValue, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId) { throw null; }
        public virtual Azure.Response DeletePredefinedTag(string tagName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeletePredefinedTagAsync(string tagName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeletePredefinedTagValue(string tagName, string tagValue, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeletePredefinedTagValueAsync(string tagName, string tagValue, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.SubscriptionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.Models.PredefinedTag> GetAllPredefinedTags(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.Models.PredefinedTag> GetAllPredefinedTagsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Resources.ArmRestApiCollection GetArmRestApis(string azureNamespace) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.SubscriptionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.FeatureResource> GetFeatures(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.FeatureResource> GetFeaturesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.GenericResource> GetGenericResources(string filter = null, string expand = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.GenericResource> GetGenericResourcesAsync(string filter = null, string expand = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.Models.LocationExpanded> GetLocations(bool? includeExtendedLocations = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.Models.LocationExpanded> GetLocationsAsync(bool? includeExtendedLocations = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.ResourceGroupResource> GetResourceGroup(string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.ResourceGroupResource>> GetResourceGroupAsync(string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Resources.ResourceGroupCollection GetResourceGroups() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.ResourceProviderResource> GetResourceProvider(string resourceProviderNamespace, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.ResourceProviderResource>> GetResourceProviderAsync(string resourceProviderNamespace, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Resources.ResourceProviderCollection GetResourceProviders() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.SubscriptionPolicyDefinitionResource> GetSubscriptionPolicyDefinition(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.SubscriptionPolicyDefinitionResource>> GetSubscriptionPolicyDefinitionAsync(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Resources.SubscriptionPolicyDefinitionCollection GetSubscriptionPolicyDefinitions() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.SubscriptionPolicySetDefinitionResource> GetSubscriptionPolicySetDefinition(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.SubscriptionPolicySetDefinitionResource>> GetSubscriptionPolicySetDefinitionAsync(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Resources.SubscriptionPolicySetDefinitionCollection GetSubscriptionPolicySetDefinitions() { throw null; }
    }
    public partial class TagResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected TagResource() { }
        public virtual Azure.ResourceManager.Resources.TagResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.TagResource> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.TagResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.TagResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.TagResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string scope) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.TagResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.TagResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This method is obsolete and will be removed in a future release.", false)]
        public virtual Azure.Response<Azure.ResourceManager.Resources.TagResource> Update(Azure.ResourceManager.Resources.Models.TagResourcePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.TagResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.Models.TagResourcePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This method is obsolete and will be removed in a future release.", false)]
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.TagResource>> UpdateAsync(Azure.ResourceManager.Resources.Models.TagResourcePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Resources.TagResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Resources.Models.TagResourcePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class TagResourceData : Azure.ResourceManager.Models.ResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.TagResourceData>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.TagResourceData>
    {
        public TagResourceData(Azure.ResourceManager.Resources.Models.Tag properties) { }
        public System.Collections.Generic.IDictionary<string, string> TagValues { get { throw null; } }
        Azure.ResourceManager.Resources.TagResourceData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.TagResourceData>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.TagResourceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.TagResourceData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.TagResourceData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.TagResourceData>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.TagResourceData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TenantCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.TenantResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.TenantResource>, System.Collections.IEnumerable
    {
        protected TenantCollection() { }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.TenantResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.TenantResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Resources.TenantResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.TenantResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Resources.TenantResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.TenantResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class TenantData : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.TenantData>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.TenantData>
    {
        internal TenantData() { }
        public string Country { get { throw null; } }
        public string CountryCode { get { throw null; } }
        public string DefaultDomain { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Domains { get { throw null; } }
        public string Id { get { throw null; } }
        public System.Uri TenantBrandingLogoUri { get { throw null; } }
        public Azure.ResourceManager.Resources.Models.TenantCategory? TenantCategory { get { throw null; } }
        public System.Guid? TenantId { get { throw null; } }
        public string TenantType { get { throw null; } }
        Azure.ResourceManager.Resources.TenantData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.TenantData>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.TenantData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.TenantData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.TenantData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.TenantData>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.TenantData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TenantPolicyDefinitionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.TenantPolicyDefinitionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.TenantPolicyDefinitionResource>, System.Collections.IEnumerable
    {
        protected TenantPolicyDefinitionCollection() { }
        public virtual Azure.Response<bool> Exists(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.TenantPolicyDefinitionResource> Get(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.TenantPolicyDefinitionResource> GetAll(string filter = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.TenantPolicyDefinitionResource> GetAllAsync(string filter = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.TenantPolicyDefinitionResource>> GetAsync(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Resources.TenantPolicyDefinitionResource> GetIfExists(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Resources.TenantPolicyDefinitionResource>> GetIfExistsAsync(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Resources.TenantPolicyDefinitionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.TenantPolicyDefinitionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Resources.TenantPolicyDefinitionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.TenantPolicyDefinitionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class TenantPolicyDefinitionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected TenantPolicyDefinitionResource() { }
        public virtual Azure.ResourceManager.Resources.PolicyDefinitionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string policyDefinitionName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.TenantPolicyDefinitionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.TenantPolicyDefinitionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class TenantPolicySetDefinitionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.TenantPolicySetDefinitionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.TenantPolicySetDefinitionResource>, System.Collections.IEnumerable
    {
        protected TenantPolicySetDefinitionCollection() { }
        public virtual Azure.Response<bool> Exists(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.TenantPolicySetDefinitionResource> Get(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.TenantPolicySetDefinitionResource> GetAll(string filter = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.TenantPolicySetDefinitionResource> GetAllAsync(string filter = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.TenantPolicySetDefinitionResource>> GetAsync(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Resources.TenantPolicySetDefinitionResource> GetIfExists(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Resources.TenantPolicySetDefinitionResource>> GetIfExistsAsync(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Resources.TenantPolicySetDefinitionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Resources.TenantPolicySetDefinitionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Resources.TenantPolicySetDefinitionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.TenantPolicySetDefinitionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class TenantPolicySetDefinitionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected TenantPolicySetDefinitionResource() { }
        public virtual Azure.ResourceManager.Resources.PolicySetDefinitionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string policySetDefinitionName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.TenantPolicySetDefinitionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.TenantPolicySetDefinitionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class TenantResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected TenantResource() { }
        public virtual Azure.ResourceManager.Resources.TenantData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Resources.DataPolicyManifestResource> GetDataPolicyManifest(string policyMode, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.DataPolicyManifestResource>> GetDataPolicyManifestAsync(string policyMode, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Resources.DataPolicyManifestCollection GetDataPolicyManifests() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.GenericResource> GetGenericResource(Azure.Core.ResourceIdentifier resourceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.GenericResource>> GetGenericResourceAsync(Azure.Core.ResourceIdentifier resourceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Resources.GenericResourceCollection GetGenericResources() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ManagementGroups.ManagementGroupResource> GetManagementGroup(string groupId, Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType? expand = default(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType?), bool? recurse = default(bool?), string filter = null, string cacheControl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ManagementGroups.ManagementGroupResource>> GetManagementGroupAsync(string groupId, Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType? expand = default(Azure.ResourceManager.ManagementGroups.Models.ManagementGroupExpandType?), bool? recurse = default(bool?), string filter = null, string cacheControl = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ManagementGroups.ManagementGroupCollection GetManagementGroups() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.SubscriptionResource> GetSubscription(string subscriptionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.SubscriptionResource>> GetSubscriptionAsync(string subscriptionId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Resources.SubscriptionCollection GetSubscriptions() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.TenantPolicyDefinitionResource> GetTenantPolicyDefinition(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.TenantPolicyDefinitionResource>> GetTenantPolicyDefinitionAsync(string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Resources.TenantPolicyDefinitionCollection GetTenantPolicyDefinitions() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.TenantPolicySetDefinitionResource> GetTenantPolicySetDefinition(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.TenantPolicySetDefinitionResource>> GetTenantPolicySetDefinitionAsync(string policySetDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Resources.TenantPolicySetDefinitionCollection GetTenantPolicySetDefinitions() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Resources.Models.TenantResourceProvider> GetTenantResourceProvider(string resourceProviderNamespace, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Resources.Models.TenantResourceProvider>> GetTenantResourceProviderAsync(string resourceProviderNamespace, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This method is obsolete as the `top` parameter is not supported by service and will be removed in a future release.", false)]
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.Models.TenantResourceProvider> GetTenantResourceProviders(int? top, string expand, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.Models.TenantResourceProvider> GetTenantResourceProviders(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This method is obsolete as the `top` parameter is not supported by service and will be removed in a future release.", false)]
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.Models.TenantResourceProvider> GetTenantResourceProvidersAsync(int? top, string expand, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.Models.TenantResourceProvider> GetTenantResourceProvidersAsync(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Resources.Models
{
    public partial class ApiProfile : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ApiProfile>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ApiProfile>
    {
        internal ApiProfile() { }
        public string ApiVersion { get { throw null; } }
        public string ProfileVersion { get { throw null; } }
        Azure.ResourceManager.Resources.Models.ApiProfile System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ApiProfile>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ApiProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ApiProfile>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ApiProfile System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ApiProfile>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ApiProfile>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ArmPolicyParameter : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ArmPolicyParameter>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ArmPolicyParameter>
    {
        public ArmPolicyParameter() { }
        public System.Collections.Generic.IList<System.BinaryData> AllowedValues { get { throw null; } }
        public System.BinaryData DefaultValue { get { throw null; } set { } }
        public Azure.ResourceManager.Resources.Models.ParameterDefinitionsValueMetadata Metadata { get { throw null; } set { } }
        public Azure.ResourceManager.Resources.Models.ArmPolicyParameterType? ParameterType { get { throw null; } set { } }
        Azure.ResourceManager.Resources.Models.ArmPolicyParameter System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ArmPolicyParameter>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ArmPolicyParameter>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ArmPolicyParameter>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ArmPolicyParameter System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ArmPolicyParameter>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ArmPolicyParameter>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ArmPolicyParameterType : System.IEquatable<Azure.ResourceManager.Resources.Models.ArmPolicyParameterType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ArmPolicyParameterType(string value) { throw null; }
        public static Azure.ResourceManager.Resources.Models.ArmPolicyParameterType Array { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.ArmPolicyParameterType Boolean { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.ArmPolicyParameterType DateTime { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.ArmPolicyParameterType Float { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.ArmPolicyParameterType Integer { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.ArmPolicyParameterType Object { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.ArmPolicyParameterType String { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Resources.Models.ArmPolicyParameterType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Resources.Models.ArmPolicyParameterType left, Azure.ResourceManager.Resources.Models.ArmPolicyParameterType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Resources.Models.ArmPolicyParameterType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Resources.Models.ArmPolicyParameterType left, Azure.ResourceManager.Resources.Models.ArmPolicyParameterType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ArmPolicyParameterValue : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ArmPolicyParameterValue>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ArmPolicyParameterValue>
    {
        public ArmPolicyParameterValue() { }
        public System.BinaryData Value { get { throw null; } set { } }
        Azure.ResourceManager.Resources.Models.ArmPolicyParameterValue System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ArmPolicyParameterValue>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ArmPolicyParameterValue>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ArmPolicyParameterValue>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ArmPolicyParameterValue System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ArmPolicyParameterValue>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ArmPolicyParameterValue>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ArmRestApi
    {
        internal ArmRestApi() { }
        public string Description { get { throw null; } }
        public string Name { get { throw null; } }
        public string Operation { get { throw null; } }
        public string Origin { get { throw null; } }
        public string Provider { get { throw null; } }
        public string Resource { get { throw null; } }
    }
    public partial class AvailabilityZoneMappings : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.AvailabilityZoneMappings>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.AvailabilityZoneMappings>
    {
        internal AvailabilityZoneMappings() { }
        public string LogicalZone { get { throw null; } }
        public string PhysicalZone { get { throw null; } }
        Azure.ResourceManager.Resources.Models.AvailabilityZoneMappings System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.AvailabilityZoneMappings>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.AvailabilityZoneMappings>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.AvailabilityZoneMappings>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.AvailabilityZoneMappings System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.AvailabilityZoneMappings>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.AvailabilityZoneMappings>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AzureRoleDefinition : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.AzureRoleDefinition>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.AzureRoleDefinition>
    {
        internal AzureRoleDefinition() { }
        public string Id { get { throw null; } }
        public bool? IsServiceRole { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.Permission> Permissions { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Scopes { get { throw null; } }
        Azure.ResourceManager.Resources.Models.AzureRoleDefinition System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.AzureRoleDefinition>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.AzureRoleDefinition>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.AzureRoleDefinition>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.AzureRoleDefinition System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.AzureRoleDefinition>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.AzureRoleDefinition>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DataManifestCustomResourceFunctionDefinition : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.DataManifestCustomResourceFunctionDefinition>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.DataManifestCustomResourceFunctionDefinition>
    {
        internal DataManifestCustomResourceFunctionDefinition() { }
        public bool? AllowCustomProperties { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> DefaultProperties { get { throw null; } }
        public Azure.Core.ResourceType? FullyQualifiedResourceType { get { throw null; } }
        public string Name { get { throw null; } }
        Azure.ResourceManager.Resources.Models.DataManifestCustomResourceFunctionDefinition System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.DataManifestCustomResourceFunctionDefinition>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.DataManifestCustomResourceFunctionDefinition>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.DataManifestCustomResourceFunctionDefinition>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.DataManifestCustomResourceFunctionDefinition System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.DataManifestCustomResourceFunctionDefinition>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.DataManifestCustomResourceFunctionDefinition>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DataPolicyManifestEffect : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.DataPolicyManifestEffect>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.DataPolicyManifestEffect>
    {
        internal DataPolicyManifestEffect() { }
        public System.BinaryData DetailsSchema { get { throw null; } }
        public string Name { get { throw null; } }
        Azure.ResourceManager.Resources.Models.DataPolicyManifestEffect System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.DataPolicyManifestEffect>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.DataPolicyManifestEffect>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.DataPolicyManifestEffect>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.DataPolicyManifestEffect System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.DataPolicyManifestEffect>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.DataPolicyManifestEffect>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EnforcementMode : System.IEquatable<Azure.ResourceManager.Resources.Models.EnforcementMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EnforcementMode(string value) { throw null; }
        public static Azure.ResourceManager.Resources.Models.EnforcementMode DoNotEnforce { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.EnforcementMode Enforced { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Resources.Models.EnforcementMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Resources.Models.EnforcementMode left, Azure.ResourceManager.Resources.Models.EnforcementMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.Resources.Models.EnforcementMode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Resources.Models.EnforcementMode left, Azure.ResourceManager.Resources.Models.EnforcementMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ExportTemplate : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ExportTemplate>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ExportTemplate>
    {
        public ExportTemplate() { }
        public string Options { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Resources { get { throw null; } }
        Azure.ResourceManager.Resources.Models.ExportTemplate System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ExportTemplate>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ExportTemplate>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ExportTemplate>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ExportTemplate System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ExportTemplate>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ExportTemplate>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExtendedLocation : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ExtendedLocation>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ExtendedLocation>
    {
        public ExtendedLocation() { }
        public Azure.ResourceManager.Resources.Models.ExtendedLocationType? ExtendedLocationType { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        Azure.ResourceManager.Resources.Models.ExtendedLocation System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ExtendedLocation>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ExtendedLocation>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ExtendedLocation>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ExtendedLocation System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ExtendedLocation>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ExtendedLocation>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ExtendedLocationType : System.IEquatable<Azure.ResourceManager.Resources.Models.ExtendedLocationType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ExtendedLocationType(string value) { throw null; }
        public static Azure.ResourceManager.Resources.Models.ExtendedLocationType EdgeZone { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Resources.Models.ExtendedLocationType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Resources.Models.ExtendedLocationType left, Azure.ResourceManager.Resources.Models.ExtendedLocationType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Resources.Models.ExtendedLocationType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Resources.Models.ExtendedLocationType left, Azure.ResourceManager.Resources.Models.ExtendedLocationType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LocationExpanded : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.LocationExpanded>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.LocationExpanded>
    {
        internal LocationExpanded() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.AvailabilityZoneMappings> AvailabilityZoneMappings { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public string Id { get { throw null; } }
        public Azure.ResourceManager.Resources.Models.LocationType? LocationType { get { throw null; } }
        public Azure.ResourceManager.Resources.Models.LocationMetadata Metadata { get { throw null; } }
        public string Name { get { throw null; } }
        public string RegionalDisplayName { get { throw null; } }
        public string SubscriptionId { get { throw null; } }
        public static implicit operator Azure.Core.AzureLocation (Azure.ResourceManager.Resources.Models.LocationExpanded location) { throw null; }
        Azure.ResourceManager.Resources.Models.LocationExpanded System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.LocationExpanded>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.LocationExpanded>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.LocationExpanded>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.LocationExpanded System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.LocationExpanded>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.LocationExpanded>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LocationMetadata : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.LocationMetadata>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.LocationMetadata>
    {
        internal LocationMetadata() { }
        public string Geography { get { throw null; } }
        public string GeographyGroup { get { throw null; } }
        public string HomeLocation { get { throw null; } }
        public double? Latitude { get { throw null; } }
        public double? Longitude { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.PairedRegion> PairedRegions { get { throw null; } }
        public string PhysicalLocation { get { throw null; } }
        public Azure.ResourceManager.Resources.Models.RegionCategory? RegionCategory { get { throw null; } }
        public Azure.ResourceManager.Resources.Models.RegionType? RegionType { get { throw null; } }
        Azure.ResourceManager.Resources.Models.LocationMetadata System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.LocationMetadata>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.LocationMetadata>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.LocationMetadata>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.LocationMetadata System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.LocationMetadata>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.LocationMetadata>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public enum LocationType
    {
        Region = 0,
        EdgeZone = 1,
    }
    public partial class ManagedByTenant : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ManagedByTenant>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ManagedByTenant>
    {
        internal ManagedByTenant() { }
        public System.Guid? TenantId { get { throw null; } }
        Azure.ResourceManager.Resources.Models.ManagedByTenant System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ManagedByTenant>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ManagedByTenant>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ManagedByTenant>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ManagedByTenant System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ManagedByTenant>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ManagedByTenant>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ManagementLockLevel : System.IEquatable<Azure.ResourceManager.Resources.Models.ManagementLockLevel>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ManagementLockLevel(string value) { throw null; }
        public static Azure.ResourceManager.Resources.Models.ManagementLockLevel CanNotDelete { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.ManagementLockLevel NotSpecified { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.ManagementLockLevel ReadOnly { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Resources.Models.ManagementLockLevel other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Resources.Models.ManagementLockLevel left, Azure.ResourceManager.Resources.Models.ManagementLockLevel right) { throw null; }
        public static implicit operator Azure.ResourceManager.Resources.Models.ManagementLockLevel (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Resources.Models.ManagementLockLevel left, Azure.ResourceManager.Resources.Models.ManagementLockLevel right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ManagementLockOwner : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ManagementLockOwner>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ManagementLockOwner>
    {
        public ManagementLockOwner() { }
        public string ApplicationId { get { throw null; } set { } }
        Azure.ResourceManager.Resources.Models.ManagementLockOwner System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ManagementLockOwner>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ManagementLockOwner>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ManagementLockOwner>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ManagementLockOwner System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ManagementLockOwner>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ManagementLockOwner>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class NonComplianceMessage : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.NonComplianceMessage>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.NonComplianceMessage>
    {
        public NonComplianceMessage(string message) { }
        public string Message { get { throw null; } set { } }
        public string PolicyDefinitionReferenceId { get { throw null; } set { } }
        Azure.ResourceManager.Resources.Models.NonComplianceMessage System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.NonComplianceMessage>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.NonComplianceMessage>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.NonComplianceMessage>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.NonComplianceMessage System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.NonComplianceMessage>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.NonComplianceMessage>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PairedRegion : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PairedRegion>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PairedRegion>
    {
        internal PairedRegion() { }
        public string Id { get { throw null; } }
        public string Name { get { throw null; } }
        public string SubscriptionId { get { throw null; } }
        Azure.ResourceManager.Resources.Models.PairedRegion System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PairedRegion>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PairedRegion>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PairedRegion>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.PairedRegion System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PairedRegion>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PairedRegion>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ParameterDefinitionsValueMetadata : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ParameterDefinitionsValueMetadata>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ParameterDefinitionsValueMetadata>
    {
        public ParameterDefinitionsValueMetadata() { }
        public System.Collections.Generic.IDictionary<string, System.BinaryData> AdditionalProperties { get { throw null; } }
        public bool? AssignPermissions { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public string StrongType { get { throw null; } set { } }
        Azure.ResourceManager.Resources.Models.ParameterDefinitionsValueMetadata System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ParameterDefinitionsValueMetadata>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ParameterDefinitionsValueMetadata>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ParameterDefinitionsValueMetadata>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ParameterDefinitionsValueMetadata System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ParameterDefinitionsValueMetadata>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ParameterDefinitionsValueMetadata>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class Permission : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.Permission>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.Permission>
    {
        internal Permission() { }
        public System.Collections.Generic.IReadOnlyList<string> AllowedActions { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> AllowedDataActions { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> DeniedActions { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> DeniedDataActions { get { throw null; } }
        Azure.ResourceManager.Resources.Models.Permission System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.Permission>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.Permission>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.Permission>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.Permission System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.Permission>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.Permission>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PolicyAssignmentPatch : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PolicyAssignmentPatch>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PolicyAssignmentPatch>
    {
        public PolicyAssignmentPatch() { }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public Azure.Core.AzureLocation? Location { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.PolicyOverride> Overrides { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.ResourceSelector> ResourceSelectors { get { throw null; } }
        Azure.ResourceManager.Resources.Models.PolicyAssignmentPatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PolicyAssignmentPatch>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PolicyAssignmentPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PolicyAssignmentPatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.PolicyAssignmentPatch System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PolicyAssignmentPatch>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PolicyAssignmentPatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PolicyDefinitionGroup : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PolicyDefinitionGroup>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PolicyDefinitionGroup>
    {
        public PolicyDefinitionGroup(string name) { }
        public string AdditionalMetadataId { get { throw null; } set { } }
        public string Category { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        Azure.ResourceManager.Resources.Models.PolicyDefinitionGroup System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PolicyDefinitionGroup>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PolicyDefinitionGroup>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PolicyDefinitionGroup>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.PolicyDefinitionGroup System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PolicyDefinitionGroup>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PolicyDefinitionGroup>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PolicyDefinitionReference : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PolicyDefinitionReference>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PolicyDefinitionReference>
    {
        public PolicyDefinitionReference(string policyDefinitionId) { }
        public System.Collections.Generic.IList<string> GroupNames { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.Resources.Models.ArmPolicyParameterValue> Parameters { get { throw null; } }
        public string PolicyDefinitionId { get { throw null; } set { } }
        public string PolicyDefinitionReferenceId { get { throw null; } set { } }
        Azure.ResourceManager.Resources.Models.PolicyDefinitionReference System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PolicyDefinitionReference>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PolicyDefinitionReference>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PolicyDefinitionReference>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.PolicyDefinitionReference System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PolicyDefinitionReference>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PolicyDefinitionReference>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PolicyOverride : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PolicyOverride>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PolicyOverride>
    {
        public PolicyOverride() { }
        public Azure.ResourceManager.Resources.Models.PolicyOverrideKind? Kind { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.ResourceSelectorExpression> Selectors { get { throw null; } }
        public string Value { get { throw null; } set { } }
        Azure.ResourceManager.Resources.Models.PolicyOverride System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PolicyOverride>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PolicyOverride>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PolicyOverride>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.PolicyOverride System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PolicyOverride>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PolicyOverride>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PolicyOverrideKind : System.IEquatable<Azure.ResourceManager.Resources.Models.PolicyOverrideKind>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PolicyOverrideKind(string value) { throw null; }
        public static Azure.ResourceManager.Resources.Models.PolicyOverrideKind PolicyEffect { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Resources.Models.PolicyOverrideKind other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Resources.Models.PolicyOverrideKind left, Azure.ResourceManager.Resources.Models.PolicyOverrideKind right) { throw null; }
        public static implicit operator Azure.ResourceManager.Resources.Models.PolicyOverrideKind (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Resources.Models.PolicyOverrideKind left, Azure.ResourceManager.Resources.Models.PolicyOverrideKind right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PolicyType : System.IEquatable<Azure.ResourceManager.Resources.Models.PolicyType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PolicyType(string value) { throw null; }
        public static Azure.ResourceManager.Resources.Models.PolicyType BuiltIn { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.PolicyType Custom { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.PolicyType NotSpecified { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.PolicyType Static { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Resources.Models.PolicyType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Resources.Models.PolicyType left, Azure.ResourceManager.Resources.Models.PolicyType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Resources.Models.PolicyType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Resources.Models.PolicyType left, Azure.ResourceManager.Resources.Models.PolicyType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PredefinedTag : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PredefinedTag>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PredefinedTag>
    {
        internal PredefinedTag() { }
        public Azure.ResourceManager.Resources.Models.PredefinedTagCount Count { get { throw null; } }
        public string Id { get { throw null; } }
        public string TagName { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.PredefinedTagValue> Values { get { throw null; } }
        Azure.ResourceManager.Resources.Models.PredefinedTag System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PredefinedTag>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PredefinedTag>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PredefinedTag>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.PredefinedTag System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PredefinedTag>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PredefinedTag>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PredefinedTagCount : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PredefinedTagCount>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PredefinedTagCount>
    {
        internal PredefinedTagCount() { }
        public string PredefinedTagCountType { get { throw null; } }
        public int? Value { get { throw null; } }
        Azure.ResourceManager.Resources.Models.PredefinedTagCount System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PredefinedTagCount>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PredefinedTagCount>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PredefinedTagCount>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.PredefinedTagCount System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PredefinedTagCount>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PredefinedTagCount>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PredefinedTagValue : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PredefinedTagValue>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PredefinedTagValue>
    {
        internal PredefinedTagValue() { }
        public Azure.ResourceManager.Resources.Models.PredefinedTagCount Count { get { throw null; } }
        public string Id { get { throw null; } }
        public string TagValue { get { throw null; } }
        Azure.ResourceManager.Resources.Models.PredefinedTagValue System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PredefinedTagValue>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.PredefinedTagValue>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PredefinedTagValue>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.PredefinedTagValue System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PredefinedTagValue>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.PredefinedTagValue>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProviderAuthorizationConsentState : System.IEquatable<Azure.ResourceManager.Resources.Models.ProviderAuthorizationConsentState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProviderAuthorizationConsentState(string value) { throw null; }
        public static Azure.ResourceManager.Resources.Models.ProviderAuthorizationConsentState Consented { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.ProviderAuthorizationConsentState NotRequired { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.ProviderAuthorizationConsentState NotSpecified { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.ProviderAuthorizationConsentState Required { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Resources.Models.ProviderAuthorizationConsentState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Resources.Models.ProviderAuthorizationConsentState left, Azure.ResourceManager.Resources.Models.ProviderAuthorizationConsentState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Resources.Models.ProviderAuthorizationConsentState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Resources.Models.ProviderAuthorizationConsentState left, Azure.ResourceManager.Resources.Models.ProviderAuthorizationConsentState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ProviderExtendedLocation : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ProviderExtendedLocation>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ProviderExtendedLocation>
    {
        internal ProviderExtendedLocation() { }
        public System.Collections.Generic.IReadOnlyList<string> ExtendedLocations { get { throw null; } }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public string ProviderExtendedLocationType { get { throw null; } }
        Azure.ResourceManager.Resources.Models.ProviderExtendedLocation System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ProviderExtendedLocation>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ProviderExtendedLocation>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ProviderExtendedLocation>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ProviderExtendedLocation System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ProviderExtendedLocation>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ProviderExtendedLocation>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ProviderPermission : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ProviderPermission>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ProviderPermission>
    {
        internal ProviderPermission() { }
        public string ApplicationId { get { throw null; } }
        public Azure.ResourceManager.Resources.Models.AzureRoleDefinition ManagedByRoleDefinition { get { throw null; } }
        public Azure.ResourceManager.Resources.Models.ProviderAuthorizationConsentState? ProviderAuthorizationConsentState { get { throw null; } }
        public Azure.ResourceManager.Resources.Models.AzureRoleDefinition RoleDefinition { get { throw null; } }
        Azure.ResourceManager.Resources.Models.ProviderPermission System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ProviderPermission>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ProviderPermission>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ProviderPermission>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ProviderPermission System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ProviderPermission>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ProviderPermission>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ProviderRegistrationContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ProviderRegistrationContent>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ProviderRegistrationContent>
    {
        public ProviderRegistrationContent() { }
        public bool? ConsentToAuthorization { get { throw null; } set { } }
        Azure.ResourceManager.Resources.Models.ProviderRegistrationContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ProviderRegistrationContent>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ProviderRegistrationContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ProviderRegistrationContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ProviderRegistrationContent System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ProviderRegistrationContent>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ProviderRegistrationContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ProviderResourceType : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ProviderResourceType>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ProviderResourceType>
    {
        internal ProviderResourceType() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.ResourceTypeAlias> Aliases { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.ApiProfile> ApiProfiles { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> ApiVersions { get { throw null; } }
        public string Capabilities { get { throw null; } }
        public string DefaultApiVersion { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.ProviderExtendedLocation> LocationMappings { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Locations { get { throw null; } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> Properties { get { throw null; } }
        public string ResourceType { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.ZoneMapping> ZoneMappings { get { throw null; } }
        Azure.ResourceManager.Resources.Models.ProviderResourceType System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ProviderResourceType>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ProviderResourceType>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ProviderResourceType>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ProviderResourceType System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ProviderResourceType>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ProviderResourceType>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RegionCategory : System.IEquatable<Azure.ResourceManager.Resources.Models.RegionCategory>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RegionCategory(string value) { throw null; }
        public static Azure.ResourceManager.Resources.Models.RegionCategory Extended { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.RegionCategory Other { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.RegionCategory Recommended { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Resources.Models.RegionCategory other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Resources.Models.RegionCategory left, Azure.ResourceManager.Resources.Models.RegionCategory right) { throw null; }
        public static implicit operator Azure.ResourceManager.Resources.Models.RegionCategory (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Resources.Models.RegionCategory left, Azure.ResourceManager.Resources.Models.RegionCategory right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RegionType : System.IEquatable<Azure.ResourceManager.Resources.Models.RegionType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RegionType(string value) { throw null; }
        public static Azure.ResourceManager.Resources.Models.RegionType Logical { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.RegionType Physical { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Resources.Models.RegionType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Resources.Models.RegionType left, Azure.ResourceManager.Resources.Models.RegionType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Resources.Models.RegionType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Resources.Models.RegionType left, Azure.ResourceManager.Resources.Models.RegionType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ResourceGroupExportResult : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceGroupExportResult>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceGroupExportResult>
    {
        internal ResourceGroupExportResult() { }
        public Azure.ResponseError Error { get { throw null; } }
        public System.BinaryData Template { get { throw null; } }
        Azure.ResourceManager.Resources.Models.ResourceGroupExportResult System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceGroupExportResult>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceGroupExportResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceGroupExportResult>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ResourceGroupExportResult System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceGroupExportResult>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceGroupExportResult>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResourceGroupPatch : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceGroupPatch>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceGroupPatch>
    {
        public ResourceGroupPatch() { }
        public string ManagedBy { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string ResourceGroupProvisioningState { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Resources.Models.ResourceGroupPatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceGroupPatch>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceGroupPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceGroupPatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ResourceGroupPatch System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceGroupPatch>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceGroupPatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResourceSelector : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceSelector>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceSelector>
    {
        public ResourceSelector() { }
        public string Name { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.ResourceSelectorExpression> Selectors { get { throw null; } }
        Azure.ResourceManager.Resources.Models.ResourceSelector System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceSelector>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceSelector>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceSelector>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ResourceSelector System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceSelector>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceSelector>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResourceSelectorExpression : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceSelectorExpression>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceSelectorExpression>
    {
        public ResourceSelectorExpression() { }
        public System.Collections.Generic.IList<string> In { get { throw null; } }
        public Azure.ResourceManager.Resources.Models.ResourceSelectorKind? Kind { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> NotIn { get { throw null; } }
        Azure.ResourceManager.Resources.Models.ResourceSelectorExpression System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceSelectorExpression>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceSelectorExpression>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceSelectorExpression>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ResourceSelectorExpression System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceSelectorExpression>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceSelectorExpression>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ResourceSelectorKind : System.IEquatable<Azure.ResourceManager.Resources.Models.ResourceSelectorKind>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ResourceSelectorKind(string value) { throw null; }
        public static Azure.ResourceManager.Resources.Models.ResourceSelectorKind PolicyDefinitionReferenceId { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.ResourceSelectorKind ResourceLocation { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.ResourceSelectorKind ResourceType { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.ResourceSelectorKind ResourceWithoutLocation { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Resources.Models.ResourceSelectorKind other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Resources.Models.ResourceSelectorKind left, Azure.ResourceManager.Resources.Models.ResourceSelectorKind right) { throw null; }
        public static implicit operator Azure.ResourceManager.Resources.Models.ResourceSelectorKind (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Resources.Models.ResourceSelectorKind left, Azure.ResourceManager.Resources.Models.ResourceSelectorKind right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ResourcesMoveContent : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourcesMoveContent>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourcesMoveContent>
    {
        public ResourcesMoveContent() { }
        public System.Collections.Generic.IList<string> Resources { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string TargetResourceGroup { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier TargetResourceGroupId { get { throw null; } set { } }
        Azure.ResourceManager.Resources.Models.ResourcesMoveContent System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourcesMoveContent>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourcesMoveContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourcesMoveContent>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ResourcesMoveContent System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourcesMoveContent>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourcesMoveContent>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResourcesSku : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourcesSku>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourcesSku>
    {
        public ResourcesSku() { }
        public int? Capacity { get { throw null; } set { } }
        public string Family { get { throw null; } set { } }
        public string Model { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Size { get { throw null; } set { } }
        public string Tier { get { throw null; } set { } }
        Azure.ResourceManager.Resources.Models.ResourcesSku System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourcesSku>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourcesSku>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourcesSku>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ResourcesSku System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourcesSku>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourcesSku>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResourceTypeAlias : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceTypeAlias>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceTypeAlias>
    {
        internal ResourceTypeAlias() { }
        public Azure.ResourceManager.Resources.Models.ResourceTypeAliasType? AliasType { get { throw null; } }
        public Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathMetadata DefaultMetadata { get { throw null; } }
        public string DefaultPath { get { throw null; } }
        public Azure.ResourceManager.Resources.Models.ResourceTypeAliasPattern DefaultPattern { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPath> Paths { get { throw null; } }
        Azure.ResourceManager.Resources.Models.ResourceTypeAlias System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceTypeAlias>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceTypeAlias>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceTypeAlias>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ResourceTypeAlias System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceTypeAlias>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceTypeAlias>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResourceTypeAliases : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliases>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliases>
    {
        internal ResourceTypeAliases() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.ResourceTypeAlias> Aliases { get { throw null; } }
        public string ResourceType { get { throw null; } }
        Azure.ResourceManager.Resources.Models.ResourceTypeAliases System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliases>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliases>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliases>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ResourceTypeAliases System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliases>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliases>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ResourceTypeAliasPath : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPath>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPath>
    {
        internal ResourceTypeAliasPath() { }
        public System.Collections.Generic.IReadOnlyList<string> ApiVersions { get { throw null; } }
        public Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathMetadata Metadata { get { throw null; } }
        public string Path { get { throw null; } }
        public Azure.ResourceManager.Resources.Models.ResourceTypeAliasPattern Pattern { get { throw null; } }
        Azure.ResourceManager.Resources.Models.ResourceTypeAliasPath System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPath>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPath>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPath>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ResourceTypeAliasPath System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPath>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPath>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ResourceTypeAliasPathAttributes : System.IEquatable<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathAttributes>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ResourceTypeAliasPathAttributes(string value) { throw null; }
        public static Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathAttributes Modifiable { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathAttributes None { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathAttributes other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathAttributes left, Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathAttributes right) { throw null; }
        public static implicit operator Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathAttributes (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathAttributes left, Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathAttributes right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ResourceTypeAliasPathMetadata : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathMetadata>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathMetadata>
    {
        internal ResourceTypeAliasPathMetadata() { }
        public Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathAttributes? Attributes { get { throw null; } }
        public Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathTokenType? TokenType { get { throw null; } }
        Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathMetadata System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathMetadata>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathMetadata>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathMetadata>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathMetadata System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathMetadata>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathMetadata>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ResourceTypeAliasPathTokenType : System.IEquatable<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathTokenType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ResourceTypeAliasPathTokenType(string value) { throw null; }
        public static Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathTokenType Any { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathTokenType Array { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathTokenType Boolean { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathTokenType Integer { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathTokenType NotSpecified { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathTokenType Number { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathTokenType Object { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathTokenType String { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathTokenType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathTokenType left, Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathTokenType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathTokenType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathTokenType left, Azure.ResourceManager.Resources.Models.ResourceTypeAliasPathTokenType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ResourceTypeAliasPattern : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPattern>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPattern>
    {
        internal ResourceTypeAliasPattern() { }
        public Azure.ResourceManager.Resources.Models.ResourceTypeAliasPatternType? PatternType { get { throw null; } }
        public string Phrase { get { throw null; } }
        public string Variable { get { throw null; } }
        Azure.ResourceManager.Resources.Models.ResourceTypeAliasPattern System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPattern>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPattern>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPattern>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ResourceTypeAliasPattern System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPattern>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ResourceTypeAliasPattern>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public enum ResourceTypeAliasPatternType
    {
        NotSpecified = 0,
        Extract = 1,
    }
    public enum ResourceTypeAliasType
    {
        NotSpecified = 0,
        PlainText = 1,
        Mask = 2,
    }
    public enum SpendingLimit
    {
        On = 0,
        Off = 1,
        CurrentPeriodOff = 2,
    }
    public partial class SubResource
    {
        public SubResource() { }
        protected internal SubResource(Azure.Core.ResourceIdentifier id) { }
        public virtual Azure.Core.ResourceIdentifier Id { get { throw null; } }
    }
    public partial class SubscriptionPolicies : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.SubscriptionPolicies>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.SubscriptionPolicies>
    {
        internal SubscriptionPolicies() { }
        public string LocationPlacementId { get { throw null; } }
        public string QuotaId { get { throw null; } }
        public Azure.ResourceManager.Resources.Models.SpendingLimit? SpendingLimit { get { throw null; } }
        Azure.ResourceManager.Resources.Models.SubscriptionPolicies System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.SubscriptionPolicies>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.SubscriptionPolicies>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.SubscriptionPolicies>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.SubscriptionPolicies System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.SubscriptionPolicies>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.SubscriptionPolicies>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public enum SubscriptionState
    {
        Enabled = 0,
        Warned = 1,
        PastDue = 2,
        Disabled = 3,
        Deleted = 4,
    }
    public partial class Tag : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.Tag>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.Tag>
    {
        public Tag() { }
        public System.Collections.Generic.IDictionary<string, string> TagValues { get { throw null; } }
        Azure.ResourceManager.Resources.Models.Tag System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.Tag>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.Tag>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.Tag>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.Tag System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.Tag>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.Tag>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TagPatchMode : System.IEquatable<Azure.ResourceManager.Resources.Models.TagPatchMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TagPatchMode(string value) { throw null; }
        public static Azure.ResourceManager.Resources.Models.TagPatchMode Delete { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.TagPatchMode Merge { get { throw null; } }
        public static Azure.ResourceManager.Resources.Models.TagPatchMode Replace { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Resources.Models.TagPatchMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Resources.Models.TagPatchMode left, Azure.ResourceManager.Resources.Models.TagPatchMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.Resources.Models.TagPatchMode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Resources.Models.TagPatchMode left, Azure.ResourceManager.Resources.Models.TagPatchMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class TagResourcePatch : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.TagResourcePatch>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.TagResourcePatch>
    {
        public TagResourcePatch() { }
        public Azure.ResourceManager.Resources.Models.TagPatchMode? PatchMode { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> TagValues { get { throw null; } }
        Azure.ResourceManager.Resources.Models.TagResourcePatch System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.TagResourcePatch>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.TagResourcePatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.TagResourcePatch>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.TagResourcePatch System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.TagResourcePatch>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.TagResourcePatch>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public enum TenantCategory
    {
        Home = 0,
        ProjectedBy = 1,
        ManagedBy = 2,
    }
    public partial class TenantResourceProvider : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.TenantResourceProvider>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.TenantResourceProvider>
    {
        internal TenantResourceProvider() { }
        public string Namespace { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.ProviderResourceType> ResourceTypes { get { throw null; } }
        Azure.ResourceManager.Resources.Models.TenantResourceProvider System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.TenantResourceProvider>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.TenantResourceProvider>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.TenantResourceProvider>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.TenantResourceProvider System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.TenantResourceProvider>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.TenantResourceProvider>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TrackedResourceExtendedData : Azure.ResourceManager.Models.TrackedResourceData, System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.TrackedResourceExtendedData>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.TrackedResourceExtendedData>
    {
        protected internal System.Collections.Generic.IDictionary<string, System.BinaryData> _serializedAdditionalRawData;
        public TrackedResourceExtendedData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.Resources.Models.ExtendedLocation ExtendedLocation { get { throw null; } set { } }
        Azure.ResourceManager.Resources.Models.TrackedResourceExtendedData System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.TrackedResourceExtendedData>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.TrackedResourceExtendedData>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.TrackedResourceExtendedData>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.TrackedResourceExtendedData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.TrackedResourceExtendedData>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.TrackedResourceExtendedData>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WritableSubResource
    {
        public WritableSubResource() { }
        protected internal WritableSubResource(Azure.Core.ResourceIdentifier id) { }
        public Azure.Core.ResourceIdentifier Id { get { throw null; } set { } }
    }
    public partial class ZoneMapping : System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ZoneMapping>, System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ZoneMapping>
    {
        internal ZoneMapping() { }
        public Azure.Core.AzureLocation? Location { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Zones { get { throw null; } }
        Azure.ResourceManager.Resources.Models.ZoneMapping System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ZoneMapping>.Read(ref System.Text.Json.Utf8JsonReader reader, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.Net.ClientModel.Core.IJsonModel<Azure.ResourceManager.Resources.Models.ZoneMapping>.Write(System.Text.Json.Utf8JsonWriter writer, System.Net.ClientModel.ModelReaderWriterOptions options) { }
        System.Net.ClientModel.ModelReaderWriterFormat System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ZoneMapping>.GetWireFormat(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        Azure.ResourceManager.Resources.Models.ZoneMapping System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ZoneMapping>.Read(System.BinaryData data, System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.Net.ClientModel.Core.IModel<Azure.ResourceManager.Resources.Models.ZoneMapping>.Write(System.Net.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
}
namespace Microsoft.Extensions.Azure
{
    public static partial class ArmClientBuilderExtensions
    {
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.ResourceManager.ArmClient, Azure.ResourceManager.ArmClientOptions> AddArmClient<TBuilder>(this TBuilder builder, string defaultSubscription) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithCredential { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.ResourceManager.ArmClient, Azure.ResourceManager.ArmClientOptions> AddArmClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
    }
}
