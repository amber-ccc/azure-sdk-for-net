// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing the ApiGatewayConfigConnection data model.
    /// A single API Management gateway resource in List or Get response.
    /// </summary>
    public partial class ApiGatewayConfigConnectionData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ApiGatewayConfigConnectionData"/>. </summary>
        public ApiGatewayConfigConnectionData()
        {
            Hostnames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ApiGatewayConfigConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> ETag of the resource. </param>
        /// <param name="provisioningState"> The current provisioning state of the API Management gateway config connection. </param>
        /// <param name="sourceId"> The link to the API Management service workspace. </param>
        /// <param name="defaultHostname"> The default hostname of the data-plane gateway. </param>
        /// <param name="hostnames"> The hostnames of the data-plane gateway to which requests can be sent. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiGatewayConfigConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? etag, string provisioningState, ResourceIdentifier sourceId, string defaultHostname, IList<string> hostnames, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ETag = etag;
            ProvisioningState = provisioningState;
            SourceId = sourceId;
            DefaultHostname = defaultHostname;
            Hostnames = hostnames;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> ETag of the resource. </summary>
        [WirePath("etag")]
        public ETag? ETag { get; }
        /// <summary> The current provisioning state of the API Management gateway config connection. </summary>
        [WirePath("properties.provisioningState")]
        public string ProvisioningState { get; }
        /// <summary> The link to the API Management service workspace. </summary>
        [WirePath("properties.sourceId")]
        public ResourceIdentifier SourceId { get; set; }
        /// <summary> The default hostname of the data-plane gateway. </summary>
        [WirePath("properties.defaultHostname")]
        public string DefaultHostname { get; }
        /// <summary> The hostnames of the data-plane gateway to which requests can be sent. </summary>
        [WirePath("properties.hostnames")]
        public IList<string> Hostnames { get; }
    }
}
