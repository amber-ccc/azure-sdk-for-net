// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Target resource. </summary>
    public partial class TargetResource
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

        /// <summary> Initializes a new instance of <see cref="TargetResource"/>. </summary>
        internal TargetResource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TargetResource"/>. </summary>
        /// <param name="id"> The Azure resource ID of the resource. </param>
        /// <param name="resourceName"> The name of the resource. </param>
        /// <param name="resourceType"> The type of the resource. </param>
        /// <param name="extension"> The extension the resource was deployed with. </param>
        /// <param name="identifiers"> The extensible resource identifiers. </param>
        /// <param name="apiVersion"> The API version the resource was deployed with. </param>
        /// <param name="symbolicName"> The symbolic name of the resource as defined in the deployment template. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TargetResource(string id, string resourceName, ResourceType? resourceType, ArmDeploymentExtensionDefinition extension, BinaryData identifiers, string apiVersion, string symbolicName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            ResourceName = resourceName;
            ResourceType = resourceType;
            Extension = extension;
            Identifiers = identifiers;
            ApiVersion = apiVersion;
            SymbolicName = symbolicName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Azure resource ID of the resource. </summary>
        [WirePath("id")]
        public string Id { get; }
        /// <summary> The name of the resource. </summary>
        [WirePath("resourceName")]
        public string ResourceName { get; }
        /// <summary> The type of the resource. </summary>
        [WirePath("resourceType")]
        public ResourceType? ResourceType { get; }
        /// <summary> The extension the resource was deployed with. </summary>
        [WirePath("extension")]
        public ArmDeploymentExtensionDefinition Extension { get; }
        /// <summary>
        /// The extensible resource identifiers.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        [WirePath("identifiers")]
        public BinaryData Identifiers { get; }
        /// <summary> The API version the resource was deployed with. </summary>
        [WirePath("apiVersion")]
        public string ApiVersion { get; }
        /// <summary> The symbolic name of the resource as defined in the deployment template. </summary>
        [WirePath("symbolicName")]
        public string SymbolicName { get; }
    }
}
