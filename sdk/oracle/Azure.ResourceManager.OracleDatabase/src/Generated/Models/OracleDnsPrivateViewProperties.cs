// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    /// <summary> Views resource model. </summary>
    public partial class OracleDnsPrivateViewProperties
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

        /// <summary> Initializes a new instance of <see cref="OracleDnsPrivateViewProperties"/>. </summary>
        /// <param name="dnsPrivateViewOcid"> The OCID of the view. </param>
        /// <param name="displayName"> The display name of the view resource. </param>
        /// <param name="isProtected"> A Boolean flag indicating whether or not parts of the resource are unable to be explicitly managed. </param>
        /// <param name="dnsPrivateViewLifecycleState"> Views lifecycleState. </param>
        /// <param name="self"> The canonical absolute URL of the resource. </param>
        /// <param name="createdOn"> views timeCreated. </param>
        /// <param name="updatedOn"> views timeCreated. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dnsPrivateViewOcid"/>, <paramref name="displayName"/> or <paramref name="self"/> is null. </exception>
        internal OracleDnsPrivateViewProperties(string dnsPrivateViewOcid, string displayName, bool isProtected, DnsPrivateViewsLifecycleState dnsPrivateViewLifecycleState, string self, DateTimeOffset createdOn, DateTimeOffset updatedOn)
        {
            Argument.AssertNotNull(dnsPrivateViewOcid, nameof(dnsPrivateViewOcid));
            Argument.AssertNotNull(displayName, nameof(displayName));
            Argument.AssertNotNull(self, nameof(self));

            DnsPrivateViewOcid = dnsPrivateViewOcid;
            DisplayName = displayName;
            IsProtected = isProtected;
            DnsPrivateViewLifecycleState = dnsPrivateViewLifecycleState;
            Self = self;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
        }

        /// <summary> Initializes a new instance of <see cref="OracleDnsPrivateViewProperties"/>. </summary>
        /// <param name="dnsPrivateViewOcid"> The OCID of the view. </param>
        /// <param name="displayName"> The display name of the view resource. </param>
        /// <param name="isProtected"> A Boolean flag indicating whether or not parts of the resource are unable to be explicitly managed. </param>
        /// <param name="dnsPrivateViewLifecycleState"> Views lifecycleState. </param>
        /// <param name="self"> The canonical absolute URL of the resource. </param>
        /// <param name="createdOn"> views timeCreated. </param>
        /// <param name="updatedOn"> views timeCreated. </param>
        /// <param name="provisioningState"> Azure resource provisioning state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OracleDnsPrivateViewProperties(string dnsPrivateViewOcid, string displayName, bool isProtected, DnsPrivateViewsLifecycleState dnsPrivateViewLifecycleState, string self, DateTimeOffset createdOn, DateTimeOffset updatedOn, OracleDatabaseResourceProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DnsPrivateViewOcid = dnsPrivateViewOcid;
            DisplayName = displayName;
            IsProtected = isProtected;
            DnsPrivateViewLifecycleState = dnsPrivateViewLifecycleState;
            Self = self;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="OracleDnsPrivateViewProperties"/> for deserialization. </summary>
        internal OracleDnsPrivateViewProperties()
        {
        }

        /// <summary> The OCID of the view. </summary>
        public string DnsPrivateViewOcid { get; }
        /// <summary> The display name of the view resource. </summary>
        public string DisplayName { get; }
        /// <summary> A Boolean flag indicating whether or not parts of the resource are unable to be explicitly managed. </summary>
        public bool IsProtected { get; }
        /// <summary> Views lifecycleState. </summary>
        public DnsPrivateViewsLifecycleState DnsPrivateViewLifecycleState { get; }
        /// <summary> The canonical absolute URL of the resource. </summary>
        public string Self { get; }
        /// <summary> views timeCreated. </summary>
        public DateTimeOffset CreatedOn { get; }
        /// <summary> views timeCreated. </summary>
        public DateTimeOffset UpdatedOn { get; }
        /// <summary> Azure resource provisioning state. </summary>
        public OracleDatabaseResourceProvisioningState? ProvisioningState { get; }
    }
}
