// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> The Extension Patch Request object. </summary>
    public partial class KubernetesClusterExtensionPatch
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KubernetesClusterExtensionPatch"/>. </summary>
        public KubernetesClusterExtensionPatch()
        {
            ConfigurationSettings = new ChangeTrackingDictionary<string, string>();
            ConfigurationProtectedSettings = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesClusterExtensionPatch"/>. </summary>
        /// <param name="autoUpgradeMinorVersion"> Flag to note if this extension participates in auto upgrade of minor version, or not. </param>
        /// <param name="releaseTrain"> ReleaseTrain this extension participates in for auto-upgrade (e.g. Stable, Preview, etc.) - only if autoUpgradeMinorVersion is 'true'. </param>
        /// <param name="version"> Version of the extension for this extension, if it is 'pinned' to a specific version. autoUpgradeMinorVersion must be 'false'. </param>
        /// <param name="configurationSettings"> Configuration settings, as name-value pairs for configuring this extension. </param>
        /// <param name="configurationProtectedSettings"> Configuration settings that are sensitive, as name-value pairs for configuring this extension. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KubernetesClusterExtensionPatch(bool? autoUpgradeMinorVersion, string releaseTrain, string version, IDictionary<string, string> configurationSettings, IDictionary<string, string> configurationProtectedSettings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AutoUpgradeMinorVersion = autoUpgradeMinorVersion;
            ReleaseTrain = releaseTrain;
            Version = version;
            ConfigurationSettings = configurationSettings;
            ConfigurationProtectedSettings = configurationProtectedSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Flag to note if this extension participates in auto upgrade of minor version, or not. </summary>
        public bool? AutoUpgradeMinorVersion { get; set; }
        /// <summary> ReleaseTrain this extension participates in for auto-upgrade (e.g. Stable, Preview, etc.) - only if autoUpgradeMinorVersion is 'true'. </summary>
        public string ReleaseTrain { get; set; }
        /// <summary> Version of the extension for this extension, if it is 'pinned' to a specific version. autoUpgradeMinorVersion must be 'false'. </summary>
        public string Version { get; set; }
        /// <summary> Configuration settings, as name-value pairs for configuring this extension. </summary>
        public IDictionary<string, string> ConfigurationSettings { get; set; }
        /// <summary> Configuration settings that are sensitive, as name-value pairs for configuring this extension. </summary>
        public IDictionary<string, string> ConfigurationProtectedSettings { get; set; }
    }
}
